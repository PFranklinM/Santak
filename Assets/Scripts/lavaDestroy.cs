using UnityEngine;
using System.Collections;

public class lavaDestroy : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {

		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "ground") {
			Destroy (this.gameObject);
		}

		if (coll.gameObject.tag == "wall") {
			Destroy (this.gameObject);
		}

		if (coll.gameObject.tag == "ceiling") {
			Destroy (this.gameObject);
		}

		if (coll.gameObject.tag == "door") {
			Destroy (this.gameObject);
		}

		if (coll.gameObject.tag == "player") {
			Destroy (this.gameObject);
		}
	}
}
