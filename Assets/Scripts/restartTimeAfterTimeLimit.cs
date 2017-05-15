using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class restartTimeAfterTimeLimit : MonoBehaviour {

	float timestamp = 300.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.anyKey) {
			timestamp = Time.time + 300.0f;
		}

		if (Time.time >= timestamp) {
			SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
		}
	
	}
}
