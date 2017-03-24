using UnityEngine;
using System.Collections;

public class squareEnemyMove : MonoBehaviour {

	public GameObject player;

	Rigidbody2D rb;

	bool touchingGround;

	float jumpCounter = 0f;

	int health;

//	public playerMove thePlayer;

	// Use this for initialization
	void Start () {

//		thePlayer = FindObjectOfType<playerMove> ();

		rb = GetComponent<Rigidbody2D>();

		touchingGround = false;

		player =  GameObject.Find ("Player");

		health = 100;

	}

	// Update is called once per frame
	void Update () {

//		if (thePlayer.canMove == false) {
//			return;
//		}

		Vector3 enemyPos = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		if (Vector3.Distance (this.transform.position, player.transform.position) < 400f) {

			if (player.transform.position.x < enemyPos.x && touchingGround == true) {

				jumpCounter += Time.deltaTime;

				if (jumpCounter > 0.25f) {

					rb.velocity = new Vector3 (-400, 1500, 0);

					touchingGround = false;

					jumpCounter = 0.0f;
				}
			}

			if (player.transform.position.x > enemyPos.x && touchingGround == true) {

				jumpCounter += Time.deltaTime;

				if (jumpCounter > 0.25f) {

					rb.velocity = new Vector3 (400, 1500, 0);

					touchingGround = false;

					jumpCounter = 0.0f;
				}
			}
		}

		if (health <= 0) {
			Destroy (this.gameObject);
		}

		transform.position = enemyPos;

		if (GameObject.Find("transitionStart1").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart2").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart3").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}


	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "ground") {
			touchingGround = true;
		}

		if (coll.gameObject.tag == "ARbullet") {
			health -= 10;
		}

//		if (coll.gameObject.tag == "player") {
//			Destroy (this.gameObject);
//		}
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "transitionEnd") {
			Destroy (this.gameObject);
		}
	}
}

