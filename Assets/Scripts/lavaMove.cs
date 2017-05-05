using UnityEngine;
using System.Collections;

public class lavaMove : MonoBehaviour {

	float timerFlash = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 rotateScale = this.GetComponent<Renderer> ().material.mainTextureScale;

		timerFlash += Time.deltaTime * Random.Range (7, 12);

		if ((int)timerFlash % 2 == 1) {
			rotateScale.x = -1;
			rotateScale.y = -1;
		}

		if ((int)timerFlash % 2 == 0) {
			rotateScale.x = 1;
			rotateScale.y = 1;
		}

		this.GetComponent<Renderer> ().material.mainTextureScale = rotateScale;
	
	}
}
