using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void SetHighlight(int id) {
		for(int i = 0; i < transform.childCount; i++){
			if(id == transform.GetChild(i).gameObject.GetComponent<ButtonController>().GetButtonFunction()){
				transform.GetChild(i).gameObject.SetActive(true);
				transform.GetChild(i).gameObject.GetComponent<ButtonController>().SetHighlight();
			}
			else{
				transform.GetChild(i).gameObject.SetActive(true);
				transform.GetChild(i).gameObject.GetComponent<ButtonController>().SetNormal();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
