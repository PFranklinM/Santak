using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textClickBack : MonoBehaviour {

	public Text back;

	bool clickable;

	// Use this for initialization
	void Start () {

		clickable = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0) && clickable == true) {
			SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
		}
	
	}

	void OnMouseEnter(){

		back.GetComponent<Text> ().color = Color.white;

		clickable = true;
	}

	void OnMouseExit() {

		back.GetComponent<Text> ().color = Color.black;

		clickable = false;
	}
}
