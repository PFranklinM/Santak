using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textClickCredits : MonoBehaviour {

	public Text credits;

	bool clickable;

	// Use this for initialization
	void Start () {

		clickable = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0) && clickable == true) {
			SceneManager.LoadScene("Credits", LoadSceneMode.Single);
		}
	
	}

	void OnMouseEnter(){

		credits.GetComponent<Text> ().color = Color.white;

		clickable = true;
	}

	void OnMouseExit() {

		credits.GetComponent<Text> ().color = Color.black;

		clickable = false;
	}
}
