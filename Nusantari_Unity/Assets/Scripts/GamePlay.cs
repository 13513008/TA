using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlay : MonoBehaviour {
	private const int PLAY = 1;
	private const int QUIT = 2;
	private const int SINGLE_PLAYER = 3;
	private const int MULTI_PLAYER = 4;
	private const int TO_MENU = 5;
	private const int GENDING = 6;
	private const int TO_PLAYMODE = 7;
	private const int EASY = 8;
	private const int NORMAL = 9;
	private const int HARD = 10;
	private const int TO_SONG = 11;
	private const int LEFT = 12;
	private const int RIGHT = 13;
	private const int TO_DIFFICULTY = 14;
	private const int ROOM = 15;
	private const int READY = 16;
	private const int PLAYMULTI = 17;
	private const int TO_HAND = 18;
	private const int MAX_PLAYER = 7;

	private int highlighted;
	private Connector connector;
	private int mode = 0;
	private int song = 0;
	private int difficulty = 0;
	private int hand = 0;
	private int master = -1;
	private bool isPlaying = false;

	public GameObject Menu, Mode, Song, Difficulty, Hand, MenuB, ModeB, SongB, DifficultyB, HandB, Dance, Room;
	public Text IP, Master;


	// Use this for initialization
	void Start () {
		connector = GetComponent<Connector>();
		connector.StartServer(MAX_PLAYER,4444);
		IP.GetComponent<Text>().text = "IP Address: " + connector.GetIPAddress();
		highlighted = 1;
	}

	public void SetHighlight(int id) {
		highlighted = id;
		if(Menu.active)
			MenuB.GetComponent<ButtonManager>().SetHighlight(id);
		if(Mode.active)
			ModeB.GetComponent<ButtonManager>().SetHighlight(id);
		if(Song.active)
			SongB.GetComponent<ButtonManager>().SetHighlight(id);
		if(Difficulty.active)
			DifficultyB.GetComponent<ButtonManager>().SetHighlight(id);
		if(Hand.active)
			HandB.GetComponent<ButtonManager>().SetHighlight(id);
	}

	public int GetHighlight() {
		return highlighted;
	}

	public void ChooseButton(){
		switch (highlighted)
        {
            case PLAY:
            	highlighted = 3;
            	Mode.SetActive(true);
            	Menu.SetActive(false);
            	// SetHighlight(3);
                break;
            case QUIT:
                Application.Quit();
                break;
            case SINGLE_PLAYER:
            	mode = 1;
            	Mode.SetActive(false);
            	Song.SetActive(true);
            	highlighted = 6;
            	break;
            case MULTI_PLAYER:
            	mode = 2;
            	Mode.SetActive(false);
            	Song.SetActive(true);
            	highlighted = 6;
            	break;
            case TO_MENU:
            	mode = 0;
            	Song.SetActive(false);
            	Menu.SetActive(true);
            	highlighted = 1;
            	break;
            case GENDING:
            	song = 1;
            	Song.SetActive(false);
            	Difficulty.SetActive(true);
            	highlighted = 8;
            	break;
            case TO_PLAYMODE:
            	song = 0;
            	Song.SetActive(false);
            	Mode.SetActive(true);
            	highlighted = 3;
            	break;
            case EASY:
            	difficulty = 1;
            	Difficulty.SetActive(false);
            	Hand.SetActive(true);
            	highlighted = 12;
            	break;
            case NORMAL:
            	difficulty = 2;
            	Difficulty.SetActive(false);
            	Hand.SetActive(true);
            	highlighted = 12;
            	break;
            case HARD:
            	difficulty = 3;
            	Difficulty.SetActive(false);
            	Hand.SetActive(true);
            	highlighted = 12;
            	break;
            case TO_SONG:
            	difficulty = 0;
            	Difficulty.SetActive(false);
            	Song.SetActive(true);
            	highlighted = 6;
            	break;
            case LEFT:
            	hand = 1;
            	// Hand.SetActive(false);
            	// isPlaying = true;
            	// Debug.Log("Play (ceritanya)");
    //         	Dance.SetActive(true);
				// Thread.Sleep(1000);
    //         	if (mode == 1)
    //         		Dance.GetComponent<PlayDance>().Record(hand);
    //         	else if (mode == 1)
    //         		Dance.GetComponent<PlayDance>().Play(connector.PlayerCount(),difficulty,hand);
            	break;
            case RIGHT:
            	hand = 2;
            	//
            	// isPlaying = true;
				Thread.Sleep(1000);	
            	if (mode == 1){
            		Dance.SetActive(true);
            		Dance.GetComponent<PlayDance>().Play(1,difficulty,hand);
            	}
            	else if (mode == 2)
            		Hand.SetActive(false);
            		Room.SetActive(true);
            		// Dance.GetComponent<PlayDance>().Play(connector.PlayerCount(),difficulty,hand);
            	break;
            case TO_DIFFICULTY:
            	hand = 0;
            	Hand.SetActive(false);
            	Difficulty.SetActive(true);
            	highlighted = 8;
            	break;
            case ROOM:
            	break;
            case PLAYMULTI:
            	Dance.SetActive(true);
            	Dance.GetComponent<PlayDance>().Play(connector.PlayerCount(),difficulty,hand);
            	break;
            case TO_HAND:
            	Room.SetActive(false);
            	Hand.SetActive(true);
            	break;
        }
	}

	public void ProcessControl() {
		int control = connector.GetControl();
		connector.RemoveControl();
		if (!isPlaying){
			switch (control)
			{
				case 1:
					ToUp();
					break;
				case 2:
					ToDown();
					break;
				case 3:
					ToLeft();
					break;
				case 4:
					ToRight();
					break;
				case 5:
					ChooseButton();
					break;
			}
		}
	}

	public void ToUp() {
		switch (highlighted)
        {
            case PLAY:
                break;
            case QUIT:
                SetHighlight(1);
                break;
            case SINGLE_PLAYER:
            	break;
            case MULTI_PLAYER:
            	break;
            case TO_MENU:
            	SetHighlight(4);
            	break;
            case GENDING:
            	break;
            case TO_PLAYMODE:
            	SetHighlight(6);
            	break;
            case EASY:
            	break;
            case NORMAL:
            	break;
            case HARD:
            	break;
            case TO_SONG:
            	SetHighlight(10);
            	break;
            case LEFT:
            	break;
            case RIGHT:
            	break;
            case TO_DIFFICULTY:
            	SetHighlight(13);
            	break;
        }
	}

	public void ToDown() {
		switch (highlighted)
        {
            case PLAY:
            	SetHighlight(2);
                break;
            case QUIT:
                break;
            case SINGLE_PLAYER:
            	SetHighlight(5);
            	break;
            case MULTI_PLAYER:
            	SetHighlight(5);
            	break;
            case TO_MENU:
            	break;
            case GENDING:
            	SetHighlight(7);
            	break;
            case TO_PLAYMODE:
            	break;
            case EASY:
            	SetHighlight(11);
            	break;
            case NORMAL:
            	SetHighlight(11);
            	break;
            case HARD:
            	SetHighlight(11);
            	break;
            case TO_SONG:
            	break;
            case LEFT:
            	SetHighlight(14);
            	break;
            case RIGHT:
            	SetHighlight(14);
            	break;
            case TO_DIFFICULTY:
            	break;
        }
	}

	public void ToLeft() {
		switch (highlighted)
        {
            case PLAY:
                break;
            case QUIT:
                break;
            case SINGLE_PLAYER:
            	break;
            case MULTI_PLAYER:
            	SetHighlight(3);
            	break;
            case TO_MENU:
            	break;
            case GENDING:
            	break;
            case TO_PLAYMODE:
            	break;
            case EASY:
            	break;
            case NORMAL:
            	SetHighlight(8);
            	break;
            case HARD:
            	SetHighlight(9);
            	break;
            case TO_SONG:
            	break;
            case LEFT:
            	break;
            case RIGHT:
            	SetHighlight(12);
            	break;
            case TO_DIFFICULTY:
            	break;
        }
	}

	public void ToRight() {
		switch (highlighted)
        {
            case PLAY:
                break;
            case QUIT:
                break;
            case SINGLE_PLAYER:
            	SetHighlight(4);
            	break;
            case MULTI_PLAYER:
            	break;
            case TO_MENU:
            	break;
            case GENDING:
            	break;
            case TO_PLAYMODE:
            	break;
            case EASY:
            	SetHighlight(9);
            	break;
            case NORMAL:
            	SetHighlight(10);
            	break;
            case HARD:
            	break;
            case TO_SONG:
            	break;
            case LEFT:
            	SetHighlight(13);
            	break;
            case RIGHT:
            	break;
            case TO_DIFFICULTY:
            	break;
        }
	}
	
	// Update is called once per frame
	void Update () {
		if (connector.GetMaster() != master) {
			master = connector.GetMaster();
			if (master == -1){
				Master.GetComponent<Text>().text = "Master: -";
			}else{
				Master.GetComponent<Text>().text = "Master: " + connector.GetMasterName();
			}
		}
		if(connector.GetControl() != 0){
			ProcessControl();
		}
	}
}
