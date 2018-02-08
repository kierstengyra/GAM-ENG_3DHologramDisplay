using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SwapModel : MonoBehaviour {

	public Button btnChanger;
	public GameObject starryNight;
	public GameObject almondBlossoms;
	public GameObject irises;

	// Use this for initialization
	void Start () {
		starryNight.SetActive (true);
		almondBlossoms.SetActive (false);
		irises.SetActive (false);

		Button btn = btnChanger.GetComponent<Button> ();
		btn.onClick.AddListener (SetModel);
	}

	public void SetModel() {
		string btnName = EventSystem.current.currentSelectedGameObject.name;

		Debug.Log ("Button: "+btnName);

		switch (btnName) {
		case "StarryNight":
			starryNight.SetActive (true);
			almondBlossoms.SetActive (false);
			irises.SetActive (false);
			break;
		case "AlmondBlossoms":
			starryNight.SetActive (false);
			almondBlossoms.SetActive (true);
			irises.SetActive (false);
			break;
		case "Irises":
			starryNight.SetActive (false);
			almondBlossoms.SetActive (false);
			irises.SetActive (true);
			break;
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
