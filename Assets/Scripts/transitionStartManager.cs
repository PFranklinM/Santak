using UnityEngine;
using System.Collections;

public class transitionStartManager : MonoBehaviour {

	float doorTimer = 0.0f;
	bool transitionIsCounting = false;

	public doorMove doorScript;

	public bool playerTouchedTransition;

	// Use this for initialization
	void Start () {

		playerTouchedTransition = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (transitionIsCounting == true) {
			doorTimer += Time.deltaTime;
		}

		if (doorTimer >= 0.95f) {
			transitionIsCounting = false;

			doorScript.timeToClose ();


			doorTimer = 0.0f;
		}
	
	}

	void OnTriggerEnter2D(Collider2D coll) {

		if (coll.gameObject.tag == "player") {

			GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition = true;

			transitionIsCounting = true;

			playerTouchedTransition = true;
		}

	}

	void OnTriggerExit2D(Collider2D coll) {

		if (coll.gameObject.tag == "player") {
			
			playerTouchedTransition = false;
		}
	}
}
