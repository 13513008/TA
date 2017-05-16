using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Room : MonoBehaviour {
	public GameObject Conn;
	private Connector connector;
	private GameObject Players;
	private Color normal = new  Vector4(0.25F, 0.25F, 0.25F, 1);
	private Color[] players = new Color[] {new  Vector4(1, 0, 0, 1), new Vector4(1, 0.5F, 0, 1), new Vector4(1, 1, 0, 1), new Vector4(0, 1, 0, 1), new Vector4(0, 0, 1, 1), new Vector4(0.5F, 0, 1, 1), new Vector4(1, 0, 1, 1)};
	private Color[] notReadyPlayers = new Color[] {new  Vector4(1, 0, 0, 0.75F), new Vector4(1, 0.5F, 0, 0.75F), new Vector4(1, 1, 0, 0.75F), new Vector4(0, 1, 0, 0.75F), new Vector4(0, 0, 1, 0.75F), new Vector4(0.5F, 0, 1, 0.75F), new Vector4(1, 0, 1, 0.75F)};
	private List<int> priority;

	// Use this for initialization
	void Awake () {
		Players = transform.Find("Players").gameObject;
		connector = Conn.GetComponent<Connector>();
		priority = new List<int>(connector.GetPriority());
		for(int i = 0; i < Players.transform.childCount; i++){
			if (i < connector.PlayerCount()){
				Players.transform.GetChild(i).gameObject.GetComponent<Image> ().color = notReadyPlayers[i];
				connector.SetPlayerColor(players[i].r,players[i].g,players[i].b,players[i].a,priority[i]);
			}else{
				Players.transform.GetChild(i).gameObject.GetComponent<Image> ().color = normal;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		List<int> newprior = connector.GetPriority();
		List<int> connected = newprior.Except(priority).ToList();
		if(connected.Count > 0){
			int i = priority.Count;
			priority = new List<int>(newprior);
			Players.transform.GetChild(i).gameObject.GetComponent<Image> ().color = notReadyPlayers[i];
			connector.SetPlayerColor(players[i].r,players[i].g,players[i].b,players[i].a,priority[i]);
		}
		List<int> disconnected = priority.Except(newprior).ToList();
		if(disconnected.Count > 0){
			int i = priority.IndexOf(disconnected[0]);
			for(int j = i; j < priority.Count - 1; j++){
				Players.transform.GetChild(j).gameObject.GetComponent<Image> ().color = Players.transform.GetChild(j+1).gameObject.GetComponent<Image> ().color;
				connector.SetPlayerColor(players[j+1].r,players[j+1].g,players[j+1].b,players[j+1].a,priority[j]);
			}
			Players.transform.GetChild(priority.Count-1).gameObject.GetComponent<Image> ().color = normal;
			priority = new List<int>(newprior);
		}
	}
}
