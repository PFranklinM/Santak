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

	float mineTimer;

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

		Vector3 playerMove = new Vector3 (player.transform.position.x,
			                     player.transform.position.y,
			                     player.transform.position.z);

		Vector3 mineMove = new Vector3 (mine.transform.position.x,
			                   mine.transform.position.y,
			                   mine.transform.position.z);

		mineTimer += Time.deltaTime;

		if (Input.GetMouseButtonDown(1) && GameObject.Find ("Mine(Clone)") != null) {

			Instantiate (explosionEffect, mine.transform.position, mine.transform.rotation);

			if (Vector3.Distance (mine.transform.position, player.transform.position) < 95) {
				player.GetComponent<Rigidbody2D> ().AddForce ((player.transform.position - mine.transform.position).normalized * playerPropulsionSpeed * Time.fixedDeltaTime);
			}

			Destroy (this.gameObject);
		}

		if (mineTimer >= 1.5f && GameObject.Find ("Mine(Clone)") != null) {
			
			Instantiate (explosionEffect, mine.transform.position, mine.transform.rotation);

			if (Vector3.Distance (mine.transform.position, player.transform.position) < 95) {
				player.GetComponent<Rigidbody2D> ().AddForce ((player.transform.position - mine.transform.position).normalized * playerPropulsionSpeed * Time.fixedDeltaTime);
			}

			Destroy (this.gameObject);
		}
	
	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "deathWall") {
			Destroy (this.gameObject);
		}
	}
}
