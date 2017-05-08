using UnityEngine;
using System.Collections;

public class lavaCircleMove : MonoBehaviour {

	float moveSpeed;

	public GameObject player;
	public GameObject lavaCircle;

	// Use this for initialization
	void Start () {

		player = GameObject.Find("Player");

		moveSpeed = -700000f;

		lavaCircle.GetComponent<Rigidbody2D> ().AddForce ((lavaCircle.transform.position - player.transform.position).normalized * moveSpeed * Time.fixedDeltaTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
