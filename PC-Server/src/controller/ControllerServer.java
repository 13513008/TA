package controller;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.TimeUnit;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.bluetooth.UUID;
import javax.microedition.io.Connector;
import javax.microedition.io.StreamConnection;
import javax.microedition.io.StreamConnectionNotifier;

import javax.bluetooth.*;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Muhammad Ridwan
 */
public class ControllerServer {
    public static int MAX_PLAYER = 7;
    
    private StreamConnection[] connections = null;
    private InputStream[] inStreams = null;
    private BufferedReader[] bReaders = null;
    private OutputStream[] outStreams = null;
    private List<String>[] messages = null;
    private List<String>[] toWrites = null;
    private List<Integer> availableSocket = null;
    private String[] names = null;
    private String[] addresses = null;
    private String[] playerNames = null;
    private List<String> disconnectedPlayers = null;
    private List<Integer> masterPriority = null;
    private int master = -1;
    
    private boolean serverState = false;
    private UUID uuid = null;
    private String connectionString = null;
    private StreamConnectionNotifier streamConnNotifier = null;
    
    public ControllerServer() {
        System.out.println("Creating ControllerServer...");
        uuid = new UUID("1101", true);
        connectionString = "btspp://localhost:" + uuid +";name=Sample SPP Server";
        
        availableSocket = new ArrayList<>();
        for(int i = 0; i < 7; i++){
            availableSocket.add(i);
        }
        
        connections = new StreamConnection[MAX_PLAYER];
        inStreams = new InputStream[MAX_PLAYER];
        bReaders = new BufferedReader[MAX_PLAYER];
        outStreams = new OutputStream[MAX_PLAYER];
        messages = new ArrayList[MAX_PLAYER];
        toWrites = new ArrayList[MAX_PLAYER];
        names = new String[MAX_PLAYER];
        addresses = new String[MAX_PLAYER];
        playerNames = new String[MAX_PLAYER];
        
        disconnectedPlayers = new ArrayList<>();
        masterPriority = new ArrayList<>();
        System.out.println("ControllerServer created.");
    }
    
    public boolean startServer() {
        System.out.println("Starting server...");
        try {
            streamConnNotifier = (StreamConnectionNotifier)Connector.open( connectionString );
        } catch (IOException ex) {
            System.out.println("Connector wouldn't open.");
            return serverState;
        }
        
        Thread connNotifier = new Thread() {            
            @Override
            public void run() {
                int socket = -1;
                while (true){
                    if (availableSocket.size() > 0){
                        try {
                            socket = availableSocket.get(0);
                            
                            System.out.println("Waiting for connection...");
                            StreamConnection connection = streamConnNotifier.acceptAndOpen();
                            connections[socket] = connection;
                            
                            RemoteDevice dev = RemoteDevice.getRemoteDevice(connections[socket]);
                            names[socket] = dev.getFriendlyName(true);
                            addresses[socket] = dev.getBluetoothAddress();
                            
                            openStream(socket);
                            
                            availableSocket.remove(0);
                            masterPriority.add(socket);
                            checkMaster();
                        } catch (IOException ex) {
                            closeConnection(socket);
                        }
                    }
                }
            }
        };        
        
        connNotifier.start();
        serverState = true;
        if (serverState)
            System.out.println("Server started.");
        else
            System.out.println("Server failed to start.");
        return serverState;
    }
    
    public void openStream(int socket) {
        System.out.println("Opening stream");
        try {
            inStreams[socket] = connections[socket].openInputStream();
            outStreams[socket] = connections[socket].openOutputStream();
            bReaders[socket] = new BufferedReader(new InputStreamReader(inStreams[socket]));
            messages[socket] = new ArrayList<>();
            toWrites[socket] = new ArrayList<>();

            Thread inStream = new Thread() {
                int id = socket;
                @Override
                public void run() {
                    System.out.println("Open input stream for device " + names[id]);
                    while(connections[id] != null){
                        try {
                            String lineRead = bReaders[id].readLine();

                            if (lineRead != null){
                                String message = lineRead;
                                messages[id].add(message);
                            }
                        } catch (IOException ex) {
                            closeConnection(id);
                        }
                    }
                }
            };

            Thread outStream = new Thread() {
                int id = socket;
                @Override
                public void run() {
                    System.out.println("Open output stream for device " + names[id]);
                    while(outStreams[id] != null){
                        try {
                            if (toWrites[id].size() > 0){
                                String message = toWrites[id].get(0)+"\n";
                                outStreams[id].write(message.getBytes("UTF-8"));
                                toWrites[id].remove(0);
                            }
                        } catch (IOException ex) {
                            closeConnection(id);
                        }
                    }
                }
            };

            inStream.start();

            try {
                TimeUnit.SECONDS.sleep(1);
            } catch (InterruptedException ex) {
                Logger.getLogger(ControllerServer.class.getName()).log(Level.SEVERE, null, ex);
            }

            
            toWrites[socket].add("connected");
            outStream.start();
            System.out.println("Stream opened.");
            
            try {
                TimeUnit.SECONDS.sleep(1);
            } catch (InterruptedException ex) {
                Logger.getLogger(ControllerServer.class.getName()).log(Level.SEVERE, null, ex);
            }
            
            playerNames[socket] = messages[socket].get(messages[socket].size() - 1);
            messages[socket].clear();
            System.out.println("Player name: " + playerNames[socket]);
        } catch (IOException ex) {
            System.out.println("Couldn't open stream");
            closeConnection(socket);
        }
    }
    
    public void closeConnection(int socket) {
        System.out.println("Closing connection for device " + names[socket]);
        try {
            System.out.println("Clearing messages...");
            if (messages[socket] != null)
                messages[socket].clear();
            messages[socket] = null;
            
            System.out.println("Closing buffered reader...");
            if (bReaders[socket] != null)
                bReaders[socket].close();
            bReaders[socket] = null;
            
            System.out.println("Closing input stream...");
            if (inStreams[socket] != null)
                inStreams[socket].close();
            inStreams[socket] = null;
            
            System.out.println("Clearing to write...");
            if (toWrites[socket] != null)
                toWrites[socket].clear();
            toWrites[socket] = null;
            
            System.out.println("Closing output stream...");
            if (outStreams[socket] != null)
                outStreams[socket].close();
            outStreams[socket] = null;
            
            if (connections[socket] != null)
                connections[socket].close();
            connections[socket] = null;
            
            disconnectedPlayers.add(addresses[socket]);
            availableSocket.add(socket);
            masterPriority.remove(masterPriority.indexOf(socket));
            System.out.println("Connection closed.");
            checkMaster();
        } catch (IOException ex) {
            System.out.println("Connection failed to close.");
        }
    }
    
    public void checkMaster() {
        System.out.println("Checking master controller...");
        if (masterPriority.isEmpty()){
            master = -1;
            System.out.println("There is no connected controller.");
        }else{
            if (masterPriority.get(0) != master){
                master = masterPriority.get(0);
                addToWrite("master",master);
            }
            System.out.println("Master controller is " + names[master]);
        }
    }
    
    public int getMaster() {
        return master;
    }
    
    public void closeServer() {
        System.out.println("Closing server...");
        try {
            for(int i = 0; i < MAX_PLAYER; i++){
                closeConnection(i);
            }
            streamConnNotifier.close();
            System.out.println("Server closed.");
        } catch (IOException ex) {
            System.out.println("Server failed to close.");
        }
    }
    
    public String[] getDeviceAdresses() {
        return addresses;
    }
    
    public String[] getDeviceNames() {        
        return names;
    }
    
    public String[] getplayerNames() {
        return playerNames;
    }
    
    public String getplayerNames(int id) {
        return playerNames[id];
    }
    
    public String getMessage(int socket) {
        String message = null;
        if (messages[socket] != null) {
            if (messages[socket].size() > 0){
                message = messages[socket].get(0);
                messages[socket].remove(0);
            }
        }
        return message;
    }
    
    public void addToWrite(String message, int socket){
        toWrites[socket].add(message);
    }
    
//    public static void main(String[] args) {
//        ControllerServer cs = new ControllerServer();
//        cs.startServer();
//    }
}
