using UnityEngine;
using System.Collections;

public class playerOutlineTurn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(GameObject.Find ("Player").GetComponent<playerMove> ().facingLeft == true) {

			transform.rotation = Quaternion.Euler(0, 0, 0);
		}

		if(GameObject.Find ("Player").GetComponent<playerMove> ().facingRight == true) {

			transform.rotation = Quaternion.Euler(0, 180, 0);
		}
	
	}
}
