using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class textClickSG : MonoBehaviour {

	public Text SG;

	bool clickable;

	// Use this for initialization
	void Start () {

		clickable = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0) && clickable == true) {
			SceneManager.LoadScene("OpeningCinematic", LoadSceneMode.Single);
		}
		
	}

	void OnMouseEnter(){

		SG.GetComponent<Text> ().color = Color.white;

		clickable = true;
	}

	void OnMouseExit() {
		
		SG.GetComponent<Text> ().color = Color.black;

		clickable = false;
	}
}
