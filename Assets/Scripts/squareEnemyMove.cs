using UnityEngine;
using System.Collections;

public class squareEnemyMove : MonoBehaviour {

	public GameObject player;
	public GameObject key1;

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

		player = GameObject.Find ("Player");
		key1 = GameObject.Find("Key1");

		health = 100;

	}

	// Update is called once per frame
	void Update () {

//		if (thePlayer.canMove == false) {
//			return;
//		}

		Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), key1.GetComponent<Collider2D>());

		Vector3 enemyPos = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		if (Vector3.Distance (this.transform.position, player.transform.position) < 400f && 
			GameObject.Find("Player").GetComponent<playerMove> ().playerInvulnerable == false) {

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

		if (GameObject.Find ("Player").GetComponent<playerMove> ().playerInvulnerable == true) {
			Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), player.GetComponent<Collider2D> ());
		} else {
			Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), player.GetComponent<Collider2D> (), false);
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

		if (GameObject.Find("transitionStart4").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart5").GetComponent<lockedTransitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart6").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}
//
//		if (GameObject.Find("transitionStart7").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//			Destroy (this.gameObject);
//		}
//
//		if (GameObject.Find("transitionStart8").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//			Destroy (this.gameObject);
//		}
//
//		if (GameObject.Find("transitionStart9").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//			Destroy (this.gameObject);
//		}
//
//		if (GameObject.Find("transitionStart10").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//			Destroy (this.gameObject);
//		}
//
//		if (GameObject.Find("transitionStart11").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//			Destroy (this.gameObject);
//		}
//
//		if (GameObject.Find("transitionStart12").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//			Destroy (this.gameObject);
//		}
//
//		if (GameObject.Find("transitionStart13").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//			Destroy (this.gameObject);
//		}
//
//		if (GameObject.Find("transitionStart14").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//			Destroy (this.gameObject);
//		}
//
//		if (GameObject.Find("transitionStart15").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//			Destroy (this.gameObject);
//		}



		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM1Checkpoint == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM2CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM2CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM4CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM4CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM6CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM6CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM7CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM7CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM8CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM8CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM9CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM9CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM10CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM10CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM11CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM11CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM12CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM12CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM13CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM13CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM14CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM14CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM15CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM15CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (Vector3.Distance (this.transform.position, player.transform.position) < 100f) {
			GameObject.Find ("Player").GetComponent<playerMove> ().playerjustDied = false;
		}

	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "ground") {
			touchingGround = true;
		}

		if (coll.gameObject.tag == "ARbullet") {
			health -= 10;
		}
	}

//	void OnTriggerEnter2D(Collider2D coll){
//		if (coll.gameObject.tag == "transitionEnd") {
//			Destroy (this.gameObject);
//		}
//	}
}

