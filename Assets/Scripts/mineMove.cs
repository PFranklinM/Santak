using UnityEngine;
using System.Collections;

public class mineMove : MonoBehaviour {

	float moveSpeed;

	public GameObject target;
	public GameObject mine;
	public GameObject player;

	public GameObject explosionEffect;

	float targetDistance;

	float playerExplosionDistance;

	float playerPropulsionSpeed;

	// Use this for initialization
	void Start () {

		target = GameObject.Find("Target");
		player = GameObject.Find("Player");

		targetDistance = (target.transform.position - mine.transform.position).magnitude;

		moveSpeed = targetDistance * 450000f;

		mine.GetComponent<Rigidbody2D> ().AddForce ((target.transform.position - mine.transform.position).normalized * moveSpeed * Time.smoothDeltaTime);
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

//		Debug.Log (targetDistance);

//		Debug.Log (moveSpeed);

		if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift) 
			&& GameObject.Find ("Mine(Clone)") != null) {

			Instantiate (explosionEffect, mine.transform.position, mine.transform.rotation);

			playerExplosionDistance = (player.transform.position - explosionEffect.transform.position).magnitude;

			playerPropulsionSpeed = playerExplosionDistance * 1500;

			if (Vector3.Distance (mine.transform.position, player.transform.position) < 85) {
				player.GetComponent<Rigidbody2D> ().AddForce ((player.transform.position - mine.transform.position).normalized * playerPropulsionSpeed * Time.deltaTime);
			}

			Destroy (this.gameObject);
		}
	
	}
}
