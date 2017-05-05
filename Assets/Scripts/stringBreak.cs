using UnityEngine;
using System.Collections;

public class stringBreak : MonoBehaviour {

	public GameObject hangingBox1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "ARbullet") {

			hangingBox1.GetComponent<HingeJoint2D>().enabled = false;
		}

		if (coll.gameObject.tag == "SGbullet") {

			hangingBox1.GetComponent<HingeJoint2D>().enabled = false;
		}

		if (coll.gameObject.tag == "explosion") {

			hangingBox1.GetComponent<HingeJoint2D>().enabled = false;
		}
	}
}
