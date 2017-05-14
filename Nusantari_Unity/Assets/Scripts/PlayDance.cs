using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayDance : MonoBehaviour {
	public MovieTexture movie;
	private static RawImage rawImageComp;
	private static AudioSource audioS;
	private static DanceHmm hmm;
	public GameObject main;
	public static Connector connector;
	public static DanceData data;
	private static int difficulty;
	private static string danceName;
	private static int playerCount;
	private static int hand;
	private static List<double[]>[] motions;
	private static List<double[]> recorded;
	private static List<double[]> toRecognize;
	private static int[,] recording;
	private static int[][,] motionPlay;
	private Thread video;
	private static bool isRecording = false;
	public GameObject tanda, benar, salah;
	private static bool isTanda = false;
	private static bool isBenar = false;
	private static bool isSalah = false;
	private static bool isPlaying;

	// Use this for initialization
	void Awake () {
		rawImageComp = GetComponent<RawImage> ();
		audioS = GetComponent<AudioSource> ();
		hmm = GetComponent<DanceHmm> ();
		connector = main.GetComponent<Connector> ();
		danceName = this.transform.name;
		data = GetComponent<DanceData> ();
		rawImageComp.texture = movie;
		audioS.clip = movie.audioClip;
		isPlaying = true;
		// PlayClip();
		// video = new Thread(() => PlayClip());
	}

	public void Record(int _hand){
		hand = _hand;
		recorded = new List<double[]>();
		isRecording = true;
		var record = new Thread(() => Record());
		var recordData = new Thread(() => RecordData());
		
		PlayClip();

		record.Start();
		recordData.Start();
		Thread.Sleep(7000);
		recording = new int[data.difficulties.Length,2];
		for(int i = 0; i < data.difficulties.Length; i++){
			var hmmPlay = new Thread(() => RecordPlay(data.delays[i],data.intervals[i],i));
			hmmPlay.Start();
			Debug.Log("started");
		}
	}

	public void Play(int _playerCount, int _difficulty, int _hand) {
		hand = _hand;
		playerCount = _playerCount;
		difficulty = _difficulty;
		motions = new List<double[]>[playerCount];
		for(int i = 0; i < playerCount; i++){
			motions[i] = new List<double[]>();
		}
		isRecording = true;
		var play = new Thread(() => Play());
		var playData = new Thread(() => PlayData());

		PlayClip();

		play.Start();
		playData.Start();
		Thread.Sleep(7000);
		Debug.Log(data.difficulties.Length);
		List<int[,]> motionList = new List<int[,]>();
		for(int i = 0; i < playerCount; i++){
			motionList.Add(new int[data.difficulties.Length,2]);
		}
		motionPlay = motionList.ToArray();
		for(int i = 0; i < data.difficulties.Length; i++){
			if(data.difficulties[i] <= difficulty){
				var hmmPlay = new Thread(() => HMMPlay(data.delays[i],data.intervals[i],i));
				hmmPlay.Start();
				Debug.Log("started");
			}
		}
	}

	public static void Record() {
		for(int i = 0; i < 9; i++){
			connector.RequestDetect(5000);
			Thread.Sleep(5000);
		}
		isRecording = false;
		// Write the string to a file.
		System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Users\\X200MA\\Desktop\\DEAL\\result.txt");
		for(int i = 0; i < data.difficulties.Length; i++){
			for(int j = recording[i,0] + 1; j <= recording[i,1]; j++){
				file.WriteLine(""+recorded[j][0]+","+recorded[j][1]+","+recorded[j][2]+","+recorded[j][3]+","+recorded[j][4]+","+recorded[j][5]);
			}
			file.WriteLine("class,"+i+"\n");
			for(int j = recording[i,0] + 1; j <= recording[i,1]; j++){
				file.WriteLine(""+recorded[j][0]+","+recorded[j][1]+","+recorded[j][2]+",20,20,20");
			}
			file.WriteLine("class,"+i);
		}

		file.Close();
		isPlaying = false;
	}

	public static void Play() {
		for(int i = 0; i < 9; i++){
			connector.RequestDetect(5000);
			Thread.Sleep(5000);
		}

		isRecording = false;
		isPlaying = false;
		Debug.Log("End");
	}

	public static void RecordData() {
		while(isRecording){
			if(connector.GetMotion(0) != null) {
				recorded.Add(connector.GetMotion(0));
				connector.RemoveMotion(0);
			}
		}
	}

	public static void PlayData() {
		while(isRecording){
			for(int i = 0; i < connector.GetPriority().Count; i++){
				int id = connector.GetPriority()[i];
				if(connector.GetMotion(id) != null) {
					motions[id].Add(connector.GetMotion(id));
					connector.RemoveMotion(id);
				}
			}
		}
	}

	public static void RecordPlay(int delay, int interval, int id) {
		Thread.Sleep(delay);
		isTanda = true;
		recording[id,0] = recorded.Count;
		Thread.Sleep(interval);
		isTanda = false;
		recording[id,1] = recorded.Count;
		Debug.Log(""+id+"-"+(recording[id,1] - recording[id,0]));
	}

	public static void HMMPlay(int delay, int interval, int id) {
		Thread.Sleep(delay);
		isTanda = true;
		for(int i = 0; i < playerCount; i++)
			motionPlay[i][id,0] = motions[i].Count;
		Thread.Sleep(interval);
		isTanda = false;
		for(int i = 0; i < playerCount; i++){
			motionPlay[i][id,1] = motions[i].Count;
			int count = motionPlay[i][id,1] - motionPlay[i][id,0];
			toRecognize = new List<double[]>();
			for(int j = motionPlay[i][id,0] + 1; j <= motionPlay[i][id,1]; j++){
				toRecognize.Add(new double[] {motions[i][j][0], motions[i][j][1], motions[i][j][2],motions[i][j][3], motions[i][j][4], motions[i][j][5]});
				// Array.Copy(motions[i][j],motion,6);
				// toRecognize.Add(motion);
				Debug.Log("");
				if (j == motionPlay[i][id,1]){
					if (hmm.Classify(toRecognize.ToArray()) == id){
						Debug.Log("Player-"+i+", Benar!");
						isBenar = true;
					}else{
						Debug.Log("Player-"+i+", Salah!");
						isSalah = true;
					}
				}
			}
			Thread.Sleep(500);
			isBenar = false;
			isSalah = false;
			// double[][] toRecognizeAr = toRecognize.ToArray();
			// Debug.Log("S");
			// Debug.Log(hmm.Classify(toRecognize.ToArray()));
			// if (hmm.Classify(toRecognize.ToArray()) == id){
			// 	Debug.Log("Player-"+i+", Benar!");
			// }else{
			// 	Debug.Log("Player-"+i+", Salah!");
			// }
		}
		// Debug.Log(id);
		// List<double[]> motions;
		// // while(true){
		// 	connector.RequestDetect(2000);
		// 	Thread.Sleep(300);
		// 	while(connector.IsReceiving()){
		// 		Thread.Sleep(10);
		// 	}
		// 	motions = new List<double[]>();
		// 	while(connector.GetMotion(0) != null){
		// 		motions.Add(connector.GetMotion(0));
		// 		connector.RemoveMotion(0);
		// 	}
		// 	Debug.Log(hmm.Classify(motions.ToArray()));
			// 
	}

	public void PlayClip () {
		movie.Play();
		audioS.Play();
	}

	public void StopClip () {
		movie.Stop();
		audioS.Stop();
		this.gameObject.SetActive(false);
		benar.SetActive(false);
		salah.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		tanda.SetActive(isTanda);
		benar.SetActive(isBenar);
		salah.SetActive(isSalah);
		if(!isPlaying)
			StopClip();
	}
}
