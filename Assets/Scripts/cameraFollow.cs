﻿using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {

		offset = transform.position - player.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate () {

		transform.position = player.transform.position + offset;

		transform.eulerAngles = new Vector3(0, 0, 0);

	}
		
}
