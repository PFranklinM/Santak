using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HPBlink : MonoBehaviour {

	float timerFlash = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Renderer renderer = GetComponent<Renderer> ();
		Material mat = renderer.material;

		timerFlash += Time.deltaTime * 5;


		if((int)timerFlash%2==1){
			mat.SetColor ("_EmissionColor", Color.red);
			mat.SetColor ("_Color", Color.red);
		}

		if((int)timerFlash%2==0){
			mat.SetColor ("_EmissionColor", Color.white);
			mat.SetColor ("_Color", Color.white);
		}
	
	}
}
