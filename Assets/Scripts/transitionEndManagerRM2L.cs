using UnityEngine;
using System.Collections;

public class transitionEndManagerRM2L : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "player") {

			GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM1Checkpoint = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM2CheckpointL = true;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM2CheckpointR = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM3CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM3CheckpointR = false;


		}
	}
}
