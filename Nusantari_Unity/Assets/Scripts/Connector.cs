using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

public class Connector : MonoBehaviour {
	private string ipaddress;
	private static  int port, maxPlayer, master;
	private static NetworkView networkView;
	private static bool status, checkConnection, maintainConnections;
	private static bool[] isReceiving;
	private static int[] connection;
	private int requestDetect = 0;
	private static string[] names;
	private static List<string>[] messages;
	private static List<double[]>[] motions;
	private static List<int> availableId, priority, control;

	public static bool getMotion = false;

	void Awake()
	{
		networkView = GetComponent<NetworkView>();
		ipaddress = Network.player.ipAddress;
		status = false;
		master = -1;
		control = new List<int>();
	}

	public void StartServer(int maxPlayer_, int port_) {
		port = port_;
		maxPlayer = maxPlayer_;
		Network.InitializeServer(maxPlayer,port,false);
		names = new string[maxPlayer];
		messages = new List<string>[maxPlayer];
		availableId = new List<int>();
		status = true;
		isReceiving = new bool[maxPlayer];
		connection = new int[maxPlayer];
		for (int i = 0; i < maxPlayer; i++){
			availableId.Add(i);
			isReceiving[i] = false;
			connection[i] = 4;
		}
		checkConnection = false;
		maintainConnections = false;
		priority = new List<int>();
		motions = new List<double[]>[maxPlayer];
		var maintainConnection = new Thread(() => MaintainConnection());
		maintainConnection.Start();
	}

	public void StopServer() {
		status = false;
		port = 0;
		Network.Disconnect(250);
	}

	public static void SetMasterServer() {
		if(priority.Count > 0){
			if(master != priority[0]){
				master = priority[0];
				networkView.RPC("SetMaster",RPCMode.Others,master);
			}
		}
		else
			master = -1;
	}

	[RPC]
	public void SetMaster(int id_) {}

	public int GetMaster() {
		return master;
	}

	public string GetMasterName() {
		return names[master];
	}

	public string GetIPAddress() {
		return ipaddress;
	}

	public List<int> GetPriority() {
		return priority;
	}

	public string[] GetNames() {
		return names;
	}

	public int PlayerCount() {
		return priority.Count;
	}

	public string GetMessage(int id) {
		if (messages[id].Count > 0)
			return messages[id][0];
		else
			return null;
	}

	public void RemoveMessage(int id) {
		if (messages[id].Count > 0)
			messages[id].RemoveAt(0);
	}

	public double[] GetMotion(int id) {
		if (motions[id].Count > 0)
			return motions[id][0];
		else
			return null;
	}

	public void RemoveMotion(int id) {
		if (motions[id].Count > 0)
			motions[id].RemoveAt(0);
	}

	public int GetControl(){
		if (control.Count > 0)
			return control[0];
		else
			return 0;
	}

	public void RemoveControl() {
		control.RemoveAt(0);
	}

	[RPC]
	public void Register(string name, string ip_) {
		int id = availableId[0];
		names[id] = name;
		messages[id] = new List<string>();
		motions[id] = new List<double[]>();
		availableId.RemoveAt(0);
		connection[id] = 0;
		priority.Add(id);
		networkView.RPC("RegisterClient",RPCMode.Others,id,ip_);
		SetMasterServer();
	}

	[RPC]
	public void RegisterClient(int id_, string ip_) {}

	public void GetMotionDetect(int time){
		// getMotion = true;
		// var counterThread = new Thread(() => Counter(time));
		// var detectThread = new Thread(() => Detecting());
		// counterThread.Start();
		// while(getMotion){
		// 	networkView.RPC("DetectMotion",RPCMode.Others,master);
		// }
		for(int i = 0; i < priority.Count; i++){
			Debug.Log(priority[i]);
			isReceiving[i] = true;
		}
		networkView.RPC("DetectMotion",RPCMode.Others,time);
	}

	[RPC]
	public void DoneReceiving(int id_) {
		isReceiving[id_] = false;
	}

	public void RequestDetect(int time) {
		requestDetect = time;
	}

	public bool IsReceiving() {
		for(int i = 0; i < isReceiving.Length; i++)
			if (isReceiving[i])
				return true;
		return false;
	}

	public static void Counter(int time) {
		Thread.Sleep(time);
		getMotion = false;
	}

	[RPC]
	public void DetectMotion(int time) {}

	[RPC]
	public void ReceiveDetection(int id_, int[] detection) {
		double[] det = new double[detection.Length];
		for(int i = 0; i < detection.Length; i++){
			det[i] = (double)detection[i];
		}
		motions[id_].Add(det);
	}

	[RPC]
	public void ToUp() {
		control.Add(1);
	}

	[RPC]
	public void ToDown() {
		control.Add(2);
	}

	[RPC]
	public void ToLeft() {
		control.Add(3);
	}

	[RPC]
	public void ToRight() {
		control.Add(4);
	}

	[RPC]
	public void ClickButton() {
		control.Add(5);
	}

	public void VibrateClient(int id){
		networkView.RPC("Vibrate",RPCMode.Others,id);
	}

	public void SetPlayerColor(float r, float g, float b, float a, int id){
		networkView.RPC("SetColor",RPCMode.Others, r, g, b, a,id);
	}

	[RPC]
	public void SetColor(float r, float g, float b, float a, int id_){}

	public static void DisconnectClient(int id){
		names[id] = "";
		messages[id] = null;
		motions[id] = null;
		availableId.Add(id);
		priority.Remove(id);
		isReceiving[id] = false;
		connection[id] = 4;
		SetMasterServer();
	}

	public static void MaintainConnection() {
		while (status){
			checkConnection = true;
			Thread.Sleep(3000);
			maintainConnections = true;
			Thread.Sleep(1000);
		}
	}

	public void CheckConnection() {
		checkConnection = false;
		networkView.RPC("ClientResponsing",RPCMode.Others);
	}

	[RPC]
	public void DisconnectRequest(int id_){
		networkView.RPC("Disconnected",RPCMode.Others,id_);
		DisconnectClient(id_);
	}

	[RPC]
	public void Disconnected(int id_) {}

	public void CheckDisconnectedPlayer() {
		for(int i = 0; i < priority.Count; i++){
			if(connection[priority[i]] != 0){
				connection[priority[i]] += 1;
				if (connection[priority[i]] == 4){
					networkView.RPC("Disconnected",RPCMode.Others,priority[i]);
					DisconnectClient(priority[i]);
				}
			}
			else{
				connection[priority[i]] = 1;
			}
		}
		maintainConnections = false;
	}

	[RPC]
	public void ResponseConnection(int id_){
		if(id_ != -1){
			connection[id_] = 0;
		}
	}

	[RPC]
	public void ClientResponsing() {}

	void Update() {
		if(Network.peerType == NetworkPeerType.Server){
			status = true;
		}
		if(requestDetect != 0){
			GetMotionDetect(requestDetect);
			requestDetect = 0;
		}
		if(checkConnection){
			CheckConnection();
		}
		if(maintainConnections){
			CheckDisconnectedPlayer();
		}
	}
}
