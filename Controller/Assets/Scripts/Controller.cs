﻿using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
	public Text IP, Port, Name;
	public GameObject Empty, NoConn, LoginP, PlayP, Master, AccelerometerI, GyroI, Loading, Background;
	private NetworkView networkView;
	private bool isMaster = false;
	private int id = -1;
	private string ip, name, myIP, textMaster;
	private int port;
	private bool isConnected = false;
	private bool disconnectRequest = false;
	private bool accelerometer = true;
	private bool gyro = true;
	private static bool isDetecting = false;
	private static List<int[]> motions = new List<int[]>();
	private static int[] motion = new int[6];
	private Color bColor;
	public Text ID, ID_;

	// Use this for initialization
	void Start () {
		textMaster = "MASTER";
		networkView = GetComponent<NetworkView>();
		bColor = Background.GetComponent<Image>().color;
		myIP = Network.player.ipAddress;
		if (Input.acceleration.x == 0 && Input.acceleration.y == 0 && Input.acceleration.z == 0){
			accelerometer = false;
			AccelerometerI.SetActive(false);
		}
		if (Input.gyro.attitude.x == 0 && Input.gyro.attitude.y == 0 && Input.gyro.attitude.z == 0){
			gyro = false;
			GyroI.SetActive(false);
		}
	}

	public void Login() {
		if (ValidateForm()){
			string ip = IP.GetComponent<Text>().text;
			int port = Int32.Parse(Port.GetComponent<Text>().text);
			StartCoroutine(Connecting());
		}
	}

	public bool ValidateForm() {
		string ip = IP.GetComponent<Text>().text;
		string port = Port.GetComponent<Text>().text;
		string name = Name.GetComponent<Text>().text;
		if (ip == "" || port == "" || name == "") {
			Empty.SetActive(true);
			return false;
		}
		return true;
	}

	IEnumerator Connecting() {
		ip = IP.GetComponent<Text>().text;
		port = Int32.Parse(Port.GetComponent<Text>().text);
		name = Name.GetComponent<Text>().text;
		Network.Connect(ip,port);
		Loading.SetActive(true);
		yield return new WaitForSeconds(5);
		Loading.SetActive(false);
		name = Name.GetComponent<Text>().text;
		if (isConnected){
			networkView.RPC("Register",RPCMode.Server,name,myIP);
		} else {
			NoConn.SetActive(true);
		}
	}

	public void CloseEmpty() {
		Empty.SetActive(false);
	}

	public void CloseNoConn() {
		NoConn.SetActive(false);
	}

	public void Play() {
		LoginP.SetActive(false);
		PlayP.SetActive(true);
	}

	[RPC]
	public void SetMaster(int id_){
		if(id == id_){
			isMaster = true;
			Master.SetActive(isMaster);
			//master notif
		}
	}

	[RPC]
	public void Register(string name, string _ip) {}

	[RPC]
	public void RegisterClient(int id_, string ip_) {
		if(ip_ == myIP){
			id = id_;
			Play();
		}
	}

	[RPC]
	public void DetectMotion(int time) {
		isDetecting = true;

		List<int[]> detections = new List<int[]>();
		var counterThread = new Thread(() => Counter(time));
		counterThread.Start();
		// int end = 0;
		// while(end < time){
		// 	Debug.Log("A");
		// 	// textMaster = ""+detection[0];
		// 	networkView.RPC("ReceiveDetection",RPCMode.Server,id,motion);
		// 	Thread.Sleep(20);
		// }
		// networkView.RPC("DoneReceiving",RPCMode.Server,id);
	}

	public static int[] DetectMotion () {
		return new int[]{(int)Math.Floor(Input.acceleration.x*20)+20,(int)Math.Floor(Input.acceleration.y*20)+20,(int)Math.Floor(Input.acceleration.z*20)+20,(int)Math.Floor(Input.gyro.attitude.x*20)+20,(int)Math.Floor(Input.gyro.attitude.y*20)+20,(int)Math.Floor(Input.gyro.attitude.z*20)+20};
	}

	[RPC]
	public void DoneReceiving(int id_) {}

	public static void Counter(int time) {
		int end = 0;
		while(end < time){
			motions.Add(motion);
			Thread.Sleep(20);
			end += 20;
		}
		// isDetecting = false;
	}

	IEnumerator Detecting(float time){
		yield return new WaitForSeconds(time);
		isDetecting = false;
	}

	[RPC]
	public void ReceiveDetection(int id_, double[] detection) {}

	public void Up() {
		if (isMaster) {
			networkView.RPC("ToUp",RPCMode.Server);
		}
	}

	[RPC]
	public void ToUp() {}

	public void Down() {
		if (isMaster) {
			networkView.RPC("ToDown",RPCMode.Server);
		}
	}

	[RPC]
	public void ToDown() {}

	public void Left() {
		if (isMaster) {
			networkView.RPC("ToLeft",RPCMode.Server);
		}
	}

	[RPC]
	public void ToLeft() {}

	public void Right() {
		if (isMaster) {
			networkView.RPC("ToRight",RPCMode.Server);
		}
	}

	[RPC]
	public void ToRight() {}

	public void Click() {
		if (isMaster) {
			networkView.RPC("ClickButton",RPCMode.Server);
		}
	}

	[RPC]
	public void ClickButton() {}

	[RPC]
	public void Vibrate(int id_) {
		if(id == id_)
			Handheld.Vibrate();
	}

	[RPC]
	public void SetColor(Color c, int id_) {
		if (id == id_)
			Background.GetComponent<Image>().color = c;
	}

	public void Disconnect() {
		IP.GetComponent<Text>().text = "";
		Port.GetComponent<Text>().text = "";
		Name.GetComponent<Text>().text = "";
		isMaster = false;
		id = -1;
		ip = "";
		name = "";
		port = 0;
		isConnected = false;
		accelerometer = true;
		gyro = true;
		LoginP.SetActive(true);
		PlayP.SetActive(false);
		Master.SetActive(false);
		Background.GetComponent<Image>().color = bColor;
	}

	public void DisconnectToServer() {
		networkView.RPC("DisconnectRequest",RPCMode.Server,id);
	}

	[RPC]
	public void DisconnectRequest(int id_) {}

	[RPC]
	public void Disconnected(int id_) {
		Network.Disconnect(250);
		Disconnect();
	}

	public void LogoutError() {
		//Error panel
		Disconnect();
	}

	[RPC]
	public void ClientResponsing() {
		networkView.RPC("ResponseConnection",RPCMode.Server,id);
	}

	[RPC]
	public void ResponseConnection(int id_) {}
	
	// Update is called once per frame
	void Update () {
		if (Network.peerType == NetworkPeerType.Disconnected){
			isConnected = false;
			Disconnect();
		}else{
			isConnected = true;
		}
		if (!isConnected && id != -1){
			LogoutError();
		}
		if(disconnectRequest){
			// Network.Disconnect(250);
			disconnectRequest = false;
		}
		motion = DetectMotion();
		if (motions.Count > 0){
			networkView.RPC("ReceiveDetection",RPCMode.Server,id,motions[0]);
			motions.RemoveAt(0);
		}
	}
}
