using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerEnterHandler {
	public int buttonFunction;
	public GameObject gamePlay;
	private Color highlighted = new Vector4(1, 1, 1, 1);
	private Color clicked = new  Vector4(1, 174/255.0F, 101/255.0F, 1);
	private Color normal = new  Vector4(0.75F, 0.75F, 0.75F, 0.75f);
	private Image image;

	// Use this for initialization
	void Start () {
		image = transform.gameObject.GetComponent<Image> ();
		if (buttonFunction == gamePlay.GetComponent<GamePlay>().GetHighlight())
			SetHighlight();
		else
			SetNormal();
	}

	public int GetButtonFunction() {
		return buttonFunction;
	}

	public void SetHighlight() {
		image.color = highlighted;
	}

	public void SetClicked() {
		image.color = clicked;
	}

	public void ChooseButton() {
        gamePlay.GetComponent<GamePlay>().ChooseButton();
	}

	public void SetNormal() {
		image.color = normal;
	}

	public void OnPointerEnter(PointerEventData eventData) {
		gamePlay.GetComponent<GamePlay>().SetHighlight(buttonFunction);
	}

	void OnMouseDown() {
		SetClicked();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
