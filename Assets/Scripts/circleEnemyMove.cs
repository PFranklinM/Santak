using UnityEngine;
using System.Collections;

public class circleEnemyMove : MonoBehaviour {

	public GameObject player;
	public GameObject key1;

	public Vector3 startPos;
	public Vector3 endPos;
	public Vector3 dir;

	int health;

	// Use this for initialization
	void Start () {

		player = GameObject.Find("Player");
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

		if (Vector3.Distance (this.transform.position, player.transform.position) < 400f) {

			dir.Normalize ();

			Vector3 playerPos = player.transform.position;

			startPos = this.transform.position;
			endPos = playerPos;

			dir = endPos - startPos;

//			enemyPos.z = 0f;

			transform.position += dir * Time.deltaTime * 2f;
		}

		if (health <= 0) {
			Destroy (this.gameObject);
		}

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
//
//		if (GameObject.Find("transitionStart5").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//			Destroy (this.gameObject);
//		}
//
//		if (GameObject.Find("transitionStart6").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//			Destroy (this.gameObject);
//		}
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

	
	}

	void OnCollisionEnter2D(Collision2D coll){

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
