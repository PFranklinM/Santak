using UnityEngine;
using System.Collections;

public class boss2Move : MonoBehaviour {

	public GameObject player;

	float shotCounter = 0.0f;

	float spriteTimer = 0.0f;

	float moveTimer = 0.0f;

	int moveAmount = 20;

	int health;

	public Sprite standingLeft;
	public Sprite standingRight;
	public Sprite flyingLeft;
	public Sprite flyingRight;

	public GameObject specialLava;

	bool timeToSpawnMinions;

	public GameObject finalKey2;

	// Use this for initialization
	void Start () {

		finalKey2 = GameObject.Find ("TriangleKey2");

		timeToSpawnMinions = false;

		player = GameObject.Find ("Player");

		health = 500;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (finalKey2 != null) {
			Physics2D.IgnoreCollision (finalKey2.GetComponent<Collider2D> (), this.GetComponent<Collider2D> ());
		}

		Vector3 enemyPos = new Vector3 (this.transform.position.x,
			                   this.transform.position.y,
			                   this.transform.position.z);

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			                    player.transform.position.y,
			                    player.transform.position.z);

		if (Vector3.Distance (this.transform.position, player.transform.position) < 400f) {

			shotCounter += Time.deltaTime;

			spriteTimer += Time.deltaTime * 2;

			enemyPos.y -= moveAmount * Time.deltaTime;

			moveTimer += Time.deltaTime;

			if (moveTimer >= 1) {
				moveAmount = -moveAmount;
				moveTimer = 0;
			}

			if (enemyPos.x < playerPos.x) {

				if ((int)spriteTimer % 2 == 1) {
					this.GetComponent<SpriteRenderer> ().sprite = standingRight;
				}

				if ((int)spriteTimer % 2 == 0) {
					this.GetComponent<SpriteRenderer> ().sprite = flyingRight;
				}

			}

			if (enemyPos.x > playerPos.x) {

				if ((int)spriteTimer % 2 == 1) {
					this.GetComponent<SpriteRenderer> ().sprite = standingLeft;
				}

				if ((int)spriteTimer % 2 == 0) {
					this.GetComponent<SpriteRenderer> ().sprite = flyingLeft;
				}

			}

			if (shotCounter >= 1.5f) {

				timeToSpawnMinions = true;
				shotCounter = 0.0f;
			}

			if (timeToSpawnMinions == true) {

				GameObject specialLavaClone = (GameObject)Instantiate (specialLava);

				timeToSpawnMinions = false;

				Vector3 clonePos = new Vector3 (specialLavaClone.transform.position.x,
					                   specialLavaClone.transform.position.y,
					                   specialLavaClone.transform.position.z);

				clonePos.x = enemyPos.x;
				clonePos.y = enemyPos.y;
				specialLavaClone.transform.position = clonePos;

				Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), specialLavaClone.GetComponent<Collider2D> ());
			}
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

		if (GameObject.Find("transitionStart5").GetComponent<lockedTransitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart6").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart7").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart8").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart9").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart10").GetComponent<lockedTransitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart11").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart12").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart13").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}



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

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss1CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss2CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss3CheckpointL == true) {
			Destroy (this.gameObject);
		}

		this.transform.position = enemyPos;
	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "ARbullet") {

			health -= 10;

			this.GetComponent<SpriteRenderer> ().color = Color.red;

			Invoke ("changeBackToWhite", 0.15f);
		}

		if (coll.gameObject.tag == "SGbullet") {

			health -= 25;

			this.GetComponent<SpriteRenderer> ().color = Color.red;

			Invoke ("changeBackToWhite", 0.15f);
		}

		if (coll.gameObject.tag == "explosion") {

			health -= 50;

			this.GetComponent<SpriteRenderer> ().color = Color.red;

			Invoke ("changeBackToWhite", 0.15f);
		}
	}
		

	void changeBackToWhite(){
		this.GetComponent<SpriteRenderer> ().color = Color.white;
	}
}
