﻿using UnityEngine;
using System.Collections;

public class playerGetsStick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "player") {

			GameObject.Find ("Target").GetComponent<targetControl> ().playerHasMeleeAttack = true;

			Destroy (this.gameObject);
		}
	}
}
