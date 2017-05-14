package com.anup.androidbluetoothclient;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.UnsupportedEncodingException;
import java.util.UUID;


import android.app.Activity;
import android.bluetooth.BluetoothAdapter;
import android.bluetooth.BluetoothDevice;
import android.bluetooth.BluetoothSocket;
import android.content.Context;
import android.content.Intent;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.DialogInterface.OnClickListener;

import org.w3c.dom.Text;

public class MainActivity extends Activity implements SensorEventListener{
	TextView out;
	private static final int REQUEST_ENABLE_BT = 1;
	private BluetoothAdapter btAdapter = null;
	private BluetoothSocket btSocket = null;
	private OutputStream outStream = null;
	private InputStream inStream = null;

	private boolean isSend = false;

	private SensorManager sensorManager;
	private Sensor accelerometer;
	private Sensor gyroscope;

	private float lastX, lastY, lastZ;

	private float deltaXMax = 0;
	private float deltaYMax = 0;
	private float deltaZMax = 0;

	private float deltaX = 0;
	private float deltaY = 0;
	private float deltaZ = 0;

	private float deltaXrot = 0;
	private float deltaYrot = 0;
	private float deltaZrot = 0;

	private TextView currentX, currentY, currentZ, maxX, maxY, maxZ, currentXg, currentYg, currentZg;

	// Well known SPP UUID
	private static final UUID MY_UUID =
			UUID.fromString("00001101-0000-1000-8000-00805F9B34FB");

	// Insert your server's MAC address
	private static String address = "80:A5:89:5C:32:CC";

	/** Called when the activity is first created. */
	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);

		out = (TextView) findViewById(R.id.out);

		btAdapter = BluetoothAdapter.getDefaultAdapter();
		CheckBTState();

		initializeViews();

		sensorManager = (SensorManager) getSystemService(Context.SENSOR_SERVICE);
		if (sensorManager.getDefaultSensor(Sensor.TYPE_ACCELEROMETER) != null) {
			// success! we have an accelerometer

			accelerometer = sensorManager.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
			sensorManager.registerListener((SensorEventListener) this, accelerometer, SensorManager.SENSOR_DELAY_FASTEST);
			gyroscope = sensorManager.getDefaultSensor(Sensor.TYPE_GYROSCOPE);
			sensorManager.registerListener((SensorEventListener) this, gyroscope, SensorManager.SENSOR_DELAY_FASTEST);
		} else {
			// fai! we dont have an accelerometer!
		}
	}

	@Override
	public void onStart() {
		super.onStart();
//		out.append("\n...In onStart()...");
	}

	@Override
	public void onResume() {
		super.onResume();
		sensorManager.registerListener((SensorEventListener) this, accelerometer, SensorManager.SENSOR_DELAY_FASTEST);
		sensorManager.registerListener((SensorEventListener) this, gyroscope, SensorManager.SENSOR_DELAY_FASTEST);

//		out.append("\n...In onResume...\n...Attempting client connect...");


	}

//	public void start(View view){
//		Button button = (Button) findViewById(R.id.button);
//		if (!isSend) {
//			isSend = true;
//			button.setText("STOP");
//			out.setText("SENDING...");
//			Thread sender = new Thread(){
//				public void run(){
//					sendMessage();
//				}
//			};
//			sender.start();
//		}else{
//			isSend = false;
//			button.setText("START");
//		}
//	}

	public void connect(View view){
		// Set up a pointer to the remote node using it's address.
		BluetoothDevice device = btAdapter.getRemoteDevice(address);

		// Two things are needed to make a connection:
		//   A MAC address, which we got above.
		//   A Service ID or UUID.  In this case we are using the
		//     UUID for SPP.
		try {
			btSocket = device.createRfcommSocketToServiceRecord(MY_UUID);
		} catch (IOException e) {
//			AlertBox("Fatal Error", "In onResume() and socket create failed: " + e.getMessage() + ".");
			Log.d("TAG",e.getMessage());
		}

		// Discovery is resource intensive.  Make sure it isn't going on
		// when you attempt to connect and pass your message.
		btAdapter.cancelDiscovery();

		// Establish the connection.  This will block until it connects.
		try {
			btSocket.connect();
//			out.append("\n...Connection established and data link opened...");
		} catch (IOException e) {
			try {
				btSocket.close();
			} catch (IOException e2) {
//				AlertBox("Fatal Error", "In onResume() and unable to close socket during connection failure" + e2.getMessage() + ".");
				Log.d("TAG",e.getMessage());
			}
		}

		// Create a data stream so we can talk to server.
//		out.append("\n...Sending message to server...");

		try {
			outStream = btSocket.getOutputStream();
			inStream = btSocket.getInputStream();
		} catch (IOException e) {
//			AlertBox("Fatal Error", "In onResume() and output stream creation failed:" + e.getMessage() + ".");
			Log.d("TAG",e.getMessage());
		}

//		out.setText("WAITING SERVER...");

//		byte[] buffer = new byte[5];  // buffer store for the stream
//		int bytes = 0;
//		String readMessage;
//		do{
//			Log.d("TAG","ASASA");
//			try {
//				bytes = inStream.read(buffer);
//			} catch (IOException e) {
//				e.printStackTrace();
//			}
//			readMessage = new String(buffer, 0, bytes);
//			Log.d("TAG",readMessage);
//		}while(!readMessage.equals("Ready"));

//		out.setText("SENDING...");
//		while(isSend) {
//			String message = "A{"+currentX.getText()+","+currentY.getText()+","+currentZ.getText()+"},G{"+currentXg.getText()+","+currentYg.getText()+","+currentZg.getText()+"}\n";
//			Log.d("TAG",message);
//			try {
//				outStream.write(message.getBytes("UTF-8"));
//			} catch (IOException e) {
//				String msg = "In onResume() and an exception occurred during write: " + e.getMessage();
//				if (address.equals("00:00:00:00:00:00"))
//					msg = msg + ".\n\nUpdate your server address from 00:00:00:00:00:00 to the correct address on line 37 in the java code";
//				msg = msg + ".\n\nCheck that the SPP UUID: " + MY_UUID.toString() + " exists on server.\n\n";
//
//				AlertBox("Fatal Error", msg);
//			}
//		}
		Button b1 = (Button) findViewById(R.id.connect);
		Button b2 = (Button) findViewById(R.id.disconnect);
		b1.setVisibility(View.GONE);
		b2.setVisibility(View.VISIBLE);
	}

	public void disconnect(View view) {
		String message = "end\n";
		Log.d("TAG", message);
		try {
			outStream.write(message.getBytes("UTF-8"));
		} catch (IOException e) {
			String msg = "In onResume() and an exception occurred during write: " + e.getMessage();
			if (address.equals("00:00:00:00:00:00"))
				msg = msg + ".\n\nUpdate your server address from 00:00:00:00:00:00 to the correct address on line 37 in the java code";
			msg = msg + ".\n\nCheck that the SPP UUID: " + MY_UUID.toString() + " exists on server.\n\n";

			AlertBox("Fatal Error", msg);
		}
		try     {
			btSocket.close();
		} catch (IOException e2) {
			Log.d("TAG",e2.getMessage());
//			AlertBox("Fatal Error", "In onPause() and failed to close socket." + e2.getMessage() + ".");
		}
		Button b1 = (Button) findViewById(R.id.connect);
		Button b2 = (Button) findViewById(R.id.disconnect);
		b1.setVisibility(View.VISIBLE);
		b2.setVisibility(View.GONE);
	}

	public void start(View view) {
		isSend = true;
		Button b1 = (Button) findViewById(R.id.start);
		Button b2 = (Button) findViewById(R.id.pause);
		b1.setVisibility(View.GONE);
		b2.setVisibility(View.VISIBLE);
	}

	public void pause(View view) {
		String message = "pause\n";
		Log.d("TAG", message);
		try {
			outStream.write(message.getBytes("UTF-8"));
		} catch (IOException e) {
			String msg = "In onResume() and an exception occurred during write: " + e.getMessage();
			if (address.equals("00:00:00:00:00:00"))
				msg = msg + ".\n\nUpdate your server address from 00:00:00:00:00:00 to the correct address on line 37 in the java code";
			msg = msg + ".\n\nCheck that the SPP UUID: " + MY_UUID.toString() + " exists on server.\n\n";

			AlertBox("Fatal Error", msg);
		}
		isSend = false;
		Button b1 = (Button) findViewById(R.id.start);
		Button b2 = (Button) findViewById(R.id.pause);
		b1.setVisibility(View.VISIBLE);
		b2.setVisibility(View.GONE);
	}

	public void initializeViews() {
		currentX = (TextView) findViewById(R.id.currentX);
		currentY = (TextView) findViewById(R.id.currentY);
		currentZ = (TextView) findViewById(R.id.currentZ);
		currentXg = (TextView) findViewById(R.id.currentXg);
		currentYg = (TextView) findViewById(R.id.currentYg);
		currentZg = (TextView) findViewById(R.id.currentZg);
	}

	@Override
	public void onPause() {
		super.onPause();
		sensorManager.unregisterListener((SensorEventListener) this);

//		out.append("\n...In onPause()...");

		if (outStream != null) {
			try {
				outStream.flush();
			} catch (IOException e) {
				Log.d("TAG",e.getMessage());
//				AlertBox("Fatal Error", "In onPause() and failed to flush output stream: " + e.getMessage() + ".");
			}
		}

//		try     {
//			btSocket.close();
//		} catch (IOException e2) {
//			Log.d("TAG",e2.getMessage());
////			AlertBox("Fatal Error", "In onPause() and failed to close socket." + e2.getMessage() + ".");
//		}
	}

	@Override
	public void onStop() {
		super.onStop();
//		out.append("\n...In onStop()...");
	}

	@Override
	public void onDestroy() {
		super.onDestroy();
//		out.append("\n...In onDestroy()...");
	}

	private void CheckBTState() {
		// Check for Bluetooth support and then check to make sure it is turned on

		// Emulator doesn't support Bluetooth and will return null
		if(btAdapter==null) {
			AlertBox("Fatal Error", "Bluetooth Not supported. Aborting.");
		} else {
			if (btAdapter.isEnabled()) {
				out.setText("\n...READY...");
//				out.append("\n...Bluetooth is enabled...");
			} else {
				//Prompt user to turn on Bluetooth
				Intent enableBtIntent = new Intent(btAdapter.ACTION_REQUEST_ENABLE);
				startActivityForResult(enableBtIntent, REQUEST_ENABLE_BT);
			}
		}
	}

	@Override
	public void onSensorChanged(SensorEvent event) {
		Sensor sensor = event.sensor;

		if (sensor.getType() == Sensor.TYPE_ACCELEROMETER) {
			// clean current values
			displayCleanValues();
			// display the current x,y,z accelerometer values
			displayCurrentValues();
			// display the max x,y,z accelerometer values
			//        displayMaxValues();

			// get the change of the x,y,z values of the accelerometer
			deltaX = Math.abs(lastX - event.values[0]);
			deltaY = Math.abs(lastY - event.values[1]);
			deltaZ = Math.abs(lastZ - event.values[2]);

		}else if (sensor.getType() == Sensor.TYPE_GYROSCOPE) {
			// clean current values
			displayCleanValuesG();
			// display the current x,y,z accelerometer values
			displayCurrentValuesG();
			// display the max x,y,z accelerometer values
			//        displayMaxValues();

			// get the change of the x,y,z values of the accelerometer
			deltaXrot = event.values[0];
			deltaYrot = event.values[1];
			deltaZrot = event.values[2];

			// if the change is below 2, it is just plain noise
//            if (deltaXrot < 2)
//                deltaXrot = 0;
//            if (deltaYrot < 2)
//                deltaYrot = 0;
//            if ((deltaXrot > vibrateThreshold) || (deltaY > vibrateThreshold) || (deltaZ > vibrateThreshold)) {
//                v.vibrate(50);
//            }
		}
		if (isSend) {
			String message = "A{" + currentX.getText() + "," + currentY.getText() + "," + currentZ.getText() + "},G{" + currentXg.getText() + "," + currentYg.getText() + "," + currentZg.getText() + "}\n";
			Log.d("TAG", message);
			try {
				outStream.write(message.getBytes("UTF-8"));
			} catch (IOException e) {
				String msg = "In onResume() and an exception occurred during write: " + e.getMessage();
				if (address.equals("00:00:00:00:00:00"))
					msg = msg + ".\n\nUpdate your server address from 00:00:00:00:00:00 to the correct address on line 37 in the java code";
				msg = msg + ".\n\nCheck that the SPP UUID: " + MY_UUID.toString() + " exists on server.\n\n";

				AlertBox("Fatal Error", msg);
			}
		}
	}

	@Override
	public void onAccuracyChanged(Sensor sensor, int i) {

	}

	public void displayCleanValues() {
		currentX.setText("0.0");
		currentY.setText("0.0");
		currentZ.setText("0.0");
	}

	// display the current x,y,z accelerometer values
	public void displayCurrentValues() {
		currentX.setText(Float.toString(deltaX));
		currentY.setText(Float.toString(deltaY));
		currentZ.setText(Float.toString(deltaZ));
	}

	public void displayCleanValuesG() {
		currentXg.setText("0.0");
		currentYg.setText("0.0");
		currentZg.setText("0.0");
	}

	// display the current x,y,z accelerometer values
	public void displayCurrentValuesG() {
		currentXg.setText(Float.toString(deltaXrot));
		currentYg.setText(Float.toString(deltaYrot));
		currentZg.setText(Float.toString(deltaZrot));
	}

	public void AlertBox( String title, String message ){
		new AlertDialog.Builder(this)
				.setTitle( title )
				.setMessage( message + " Press OK to exit." )
				.setPositiveButton("OK", new OnClickListener() {
					public void onClick(DialogInterface arg0, int arg1) {
						finish();
					}
				}).show();
	}
}