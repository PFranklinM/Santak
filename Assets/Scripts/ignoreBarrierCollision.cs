using UnityEngine;
using System.Collections;

public class ignoreBarrierCollision : MonoBehaviour {

	public GameObject barrier1;
	public GameObject barrier2;
	public GameObject barrier3;
	public GameObject barrier4;
	public GameObject barrier5;
	public GameObject barrier6;
	public GameObject barrier7;
	public GameObject barrier8;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		barrier1 = GameObject.Find("barrier1A");
		barrier2 = GameObject.Find("barrier1B");
		barrier3 = GameObject.Find("barrier1C");
		barrier4 = GameObject.Find("barrier1D");
		barrier5 = GameObject.Find("barrier1E");
		barrier6 = GameObject.Find("barrier1F");
		barrier7 = GameObject.Find("barrier1G");
		barrier8 = GameObject.Find("barrier1H");

		if (GameObject.Find ("barrier1A") != null && GameObject.Find ("barrier1B") != null &&
			GameObject.Find ("barrier1C") != null && GameObject.Find ("barrier1D") != null &&
			GameObject.Find ("barrier1E") != null && GameObject.Find ("barrier1F") != null &&
			GameObject.Find ("barrier1G") != null && GameObject.Find ("barrier1H") != null) {

			Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), barrier1.GetComponent<Collider2D> ());
			Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), barrier2.GetComponent<Collider2D> ());
			Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), barrier3.GetComponent<Collider2D> ());
			Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), barrier4.GetComponent<Collider2D> ());
			Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), barrier5.GetComponent<Collider2D> ());
			Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), barrier6.GetComponent<Collider2D> ());
			Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), barrier7.GetComponent<Collider2D> ());
			Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), barrier8.GetComponent<Collider2D> ());
		}
	
	}
}
