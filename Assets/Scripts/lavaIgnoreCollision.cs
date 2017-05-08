using UnityEngine;
using System.Collections;

public class lavaIgnoreCollision : MonoBehaviour {

	public GameObject[] deathWall;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		deathWall = GameObject.FindGameObjectsWithTag ("deathWall");

		for (int i = 0; i < deathWall.Length; i++) {
			Physics2D.IgnoreCollision (deathWall [i].GetComponent<Collider2D> (), this.GetComponent<Collider2D> ());
		}
	
	}
}
