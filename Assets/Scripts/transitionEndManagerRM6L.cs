﻿using UnityEngine;
using System.Collections;

public class transitionEndManagerRM6L : MonoBehaviour {

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

			GameObject.Find ("Player").GetComponent<playerMove> ().RM2CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM2CheckpointR = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM3CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM3CheckpointR = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM4CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM4CheckpointR = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM5CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM5CheckpointR = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM6CheckpointL = true;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM6CheckpointR = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM7CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM7CheckpointR = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM8CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM8CheckpointR = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM9CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM9CheckpointR = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM10CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM10CheckpointR = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM11CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM11CheckpointR = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM12CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM12CheckpointR = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM13CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM13CheckpointR = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM14CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM14CheckpointR = false;

			GameObject.Find ("Player").GetComponent<playerMove> ().RM15CheckpointL = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().RM15CheckpointR = false;


		}
	}
}
