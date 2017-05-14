package ridwan.nusantari;

import android.app.Activity;
import android.bluetooth.BluetoothAdapter;
import android.bluetooth.BluetoothDevice;
import android.bluetooth.BluetoothSocket;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.Spinner;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;

public class ConnectActivity extends Activity {
    private static final int REQUEST_ENABLE_BT = 1;
    private BluetoothAdapter btAdapter = null;
    private BluetoothSocket btSocket = null;
    private BluetoothDevice device = null;
    private List<String> devices = null;
    private List<String> adresses = null;
    private OutputStream outStream = null;
    private InputStream inStream = null;
    private List<String> messages = null;
    private List<String> toWrite = null;
    private boolean isMaster = false;
    private boolean discovering = false;
    private String name = null;

    // Well known SPP UUID
    private static final UUID MY_UUID = UUID.fromString("00001101-0000-1000-8000-00805F9B34FB");

    private Spinner bluetoothDropdown;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        Log.d("Debug","onCreate");
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_connect);
        bluetoothDropdown = (Spinner)findViewById(R.id.bluetoothList);

        devices = new ArrayList<>();
        devices.add("tidak ada perangkat di sekitar");
        bluetoothDropdown.setAdapter(new ArrayAdapter<String>(this, android.R.layout.simple_spinner_dropdown_item, devices));

        btAdapter = BluetoothAdapter.getDefaultAdapter();
        if (btAdapter != null) {
            if (!btAdapter.isEnabled()) {
                //Prompt user to turn on Bluetooth
                Intent enableBtIntent = new Intent(btAdapter.ACTION_REQUEST_ENABLE);
                startActivityForResult(enableBtIntent, REQUEST_ENABLE_BT);
            }
        }else{
            devices.add("Perangkat ini tidak memiliki bluetooth");
        }
    }

    public void connectDevice(View view) {
        Log.d("Debug","connectDevice");
        if(discovering) {
            unregisterReceiver(mReceiver);
            Log.d("Debug", "Receiver unregistered");
            btAdapter.cancelDiscovery();
            Log.d("Debug", "Discovery canceled");
            discovering = false;
        }
        EditText player = (EditText)findViewById(R.id.playerName);
        name = player.getText().toString();

        device = btAdapter.getRemoteDevice(adresses.get(bluetoothDropdown.getSelectedItemPosition()));

        Thread openstream = new Thread(){
            public void run() {
                openStream();
            }
        };
        //else
        try {
            btSocket = device.createRfcommSocketToServiceRecord(MY_UUID);
            Log.d("Debug","Connecting...");
            btSocket.connect();
            Log.d("Debug","Bluetooth socket connected");
            openstream.start();
        } catch (IOException e) {
            Log.d("Debug","Couldn't connect to bluetooth socket");
            try {
                btSocket.close();
            } catch (IOException e2) {
                Log.d("Debug","Couldn't close bluetooth socket");
            }
        }
    }

    public void openStream() {
        Log.d("Debug","openStream");

        Thread oS = new Thread(){
            public void run() {
                Log.d("Debug","Opening output stream");
                try {
                    outStream = btSocket.getOutputStream();
                    while(outStream != null) {
                            if (toWrite.size() > 0) {
                                String message = toWrite.get(0) + "\n";
                                toWrite.remove(0);
                                outStream.write(message.getBytes("UTF-8"));
                            }
                    }
                } catch (IOException e) {
                    Log.d("Debug","Couldn't open output stream");
                }
            }
        };

        Thread iS = new Thread() {
            public void run() {
                try {
                    Log.d("Debug","Opening input stream");
                    inStream = btSocket.getInputStream();
                    BufferedReader r = new BufferedReader(new InputStreamReader(inStream));
                    while(r != null) {
                            String line = r.readLine();
                            messages.add(line);
                            if (line.equals("master"))
                                toMasterMode();
                    }
                } catch (IOException e) {
                    Log.d("Debug","Couldn't open input stream");
                }
            }
        };


        toWrite = new ArrayList<>();
        messages = new ArrayList<>();
        iS.start();
        oS.start();
        boolean isConnected = false;
        while(!isConnected){
            if (messages.size() > 0) {
                if (messages.get(0).equals("connected")) {
                    toWrite.clear();
                    messages.clear();
                    isConnected = true;
                    toWrite.add(name);
                    Log.d("Debug",toWrite.get(0));
                    Log.d("Debug", "Server's stream already opened");
                }
            }
            if (!isConnected) {
                if (toWrite.size() == 0)
                    toWrite.add("connect");
            }
        }
    }

    public void discoveryDevices(View view) {
        Log.d("Debug","discoveryDevices");
        if (btAdapter != null) {
            if (!btAdapter.isEnabled()) {
                //Prompt user to turn on Bluetooth
                Intent enableBtIntent = new Intent(btAdapter.ACTION_REQUEST_ENABLE);
                startActivityForResult(enableBtIntent, REQUEST_ENABLE_BT);
            }
            devices = new ArrayList<>();
            devices.add("tidak ada perangkat di sekitar");
            adresses = new ArrayList<>();
            bluetoothDropdown.setAdapter(new ArrayAdapter<String>(this, android.R.layout.simple_spinner_dropdown_item, devices));
            btAdapter.startDiscovery();
            discovering = true;

            IntentFilter filter = new IntentFilter(BluetoothDevice.ACTION_FOUND);
            registerReceiver(mReceiver, filter);
        }else{
            devices.add("Perangkat ini tidak memiliki bluetooth");
            Log.d("Debug","This device have no bluetooth");
        }
    }

    public void toMasterMode() {
        Log.d("Debug","toMasterMode");
        isMaster = true;
    }

    private final BroadcastReceiver mReceiver = new BroadcastReceiver() {
        public void onReceive(Context context, Intent intent) {
            String action = intent.getAction();
            if (BluetoothDevice.ACTION_FOUND.equals(action)) {
                BluetoothDevice device = intent
                        .getParcelableExtra(BluetoothDevice.EXTRA_DEVICE);
                Log.d("Debug","Discovered device: " + device.getName() + " (" + device.getAddress() + ")");
                devices.add(device.getName());
                adresses.add(device.getAddress());
                if ((devices.size() > 0) && (devices.get(0).equals("tidak ada perangkat di sekitar")))
                    devices.remove(0);
                bluetoothDropdown.setAdapter(new ArrayAdapter<String>(context, android.R.layout.simple_spinner_dropdown_item, devices));
            }
        }
    };
}
