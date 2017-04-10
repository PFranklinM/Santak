using UnityEngine;
using System.Collections;

public class mineMove : MonoBehaviour {

	float moveSpeed;

	public GameObject target;
	public GameObject mine;
	public GameObject player;

	public GameObject explosionEffect;

	Vector3 targetPos;

	// Use this for initialization
	void Start () {

		target = GameObject.Find("Target");
		player = GameObject.Find("Player");

		moveSpeed = 45000000f;

		mine.GetComponent<Rigidbody2D> ().AddForce ((target.transform.position - mine.transform.position).normalized * moveSpeed * Time.smoothDeltaTime);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift) 
			&& GameObject.Find ("Mine(Clone)") != null) {

			Instantiate (explosionEffect, mine.transform.position, mine.transform.rotation);

			if (Vector3.Distance (mine.transform.position, player.transform.position) < 100) {
				player.GetComponent<Rigidbody2D> ().AddForce ((player.transform.position - mine.transform.position).normalized * 2500000 * Time.deltaTime);
			}

			Destroy (this.gameObject);
		}
	
	}
}
