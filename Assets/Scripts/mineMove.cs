using UnityEngine;
using System.Collections;

public class mineMove : MonoBehaviour {

	float moveSpeed;

	public GameObject target;
	public GameObject mine;
	public GameObject player;

	public GameObject explosionEffect;

	float targetDistance;

	float playerPropulsionSpeed = 3000000f;

	// Use this for initialization
	void Start () {

		target = GameObject.Find("Target");
		player = GameObject.Find("Player");

		targetDistance = (target.transform.position - mine.transform.position).magnitude;

		moveSpeed = targetDistance * 450000f;


//		this.GetComponent<Rigidbody2D> ().velocity = new Vector3 (0, 0, 0);
		mine.GetComponent<Rigidbody2D> ().AddForce ((target.transform.position - mine.transform.position).normalized * moveSpeed * Time.fixedDeltaTime);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(1) && GameObject.Find ("Mine(Clone)") != null || Input.GetMouseButtonDown(1)
			&& GameObject.Find ("Mine(Clone)") != null) {

			Instantiate (explosionEffect, mine.transform.position, mine.transform.rotation);

			if (Vector3.Distance (mine.transform.position, player.transform.position) < 85) {
				player.GetComponent<Rigidbody2D> ().AddForce ((player.transform.position - mine.transform.position).normalized * playerPropulsionSpeed * Time.fixedDeltaTime);
			}

			Destroy (this.gameObject);
		}
	
	}
}
