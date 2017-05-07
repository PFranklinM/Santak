using UnityEngine;
using System.Collections;

public class cloudMoveH : MonoBehaviour {

	Vector2 moveScale = new Vector2 (0, 0);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		moveScale.x += 0.5f * Time.deltaTime;

		this.GetComponent<Renderer> ().material.SetTextureOffset ("_MainTex", moveScale);
	
	}
}
