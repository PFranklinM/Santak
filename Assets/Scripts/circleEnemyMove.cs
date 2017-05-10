using UnityEngine;
using System.Collections;

public class circleEnemyMove : MonoBehaviour {

	public GameObject player;
	public GameObject key1;

	public Vector3 startPos;
	public Vector3 endPos;
	public Vector3 dir;

	Rigidbody2D rb;

	public Sprite standingLeft;
	public Sprite standingRight;
	public Sprite flyingLeft;
	public Sprite flyingRight;

	float spriteTimer = 0.0f;

	int health;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();

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

		Vector3 enemyPos = new Vector3 (this.transform.position.x,
								this.transform.position.y,
								this.transform.position.z);

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			                    player.transform.position.y,
			                    player.transform.position.z);

		if (Vector3.Distance (this.transform.position, player.transform.position) < 400f &&
			GameObject.Find("Player").GetComponent<playerMove> ().playerInvulnerable == false) {

			spriteTimer += Time.deltaTime * 5;

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

			dir.Normalize ();

			startPos = this.transform.position;
			endPos = playerPos;

			dir = endPos - startPos;

//			enemyPos.z = 0f;

			transform.position += dir * Time.deltaTime * 0.75f;
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().playerInvulnerable == true) {
			Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), player.GetComponent<Collider2D> ());
		} else {
			Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), player.GetComponent<Collider2D> (), false);
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

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM11CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss1CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss1CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss2CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss2CheckpointR == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss3CheckpointL == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss3CheckpointR == true) {
			Destroy (this.gameObject);
		}


		if (Vector3.Distance (this.transform.position, player.transform.position) < 100f) {
			GameObject.Find ("Player").GetComponent<playerMove> ().playerjustDied = false;
		}
	
	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "ARbullet") {
			health -= 10;

			this.GetComponent<SpriteRenderer> ().color = Color.red;

			Invoke("changeBackToWhite", 0.15f);
		}

		if (coll.gameObject.tag == "SGbullet") {

			Vector3 bulletPos = new Vector3 (coll.gameObject.transform.position.x,
				coll.gameObject.transform.position.y,
				coll.gameObject.transform.position.z);

			Vector3 enemyPos = new Vector3 (this.transform.position.x,
				this.transform.position.y,
				this.transform.position.z);

			health -= 25;

			this.GetComponent<SpriteRenderer> ().color = Color.red;

			if (bulletPos.x > enemyPos.x) {

				rb.velocity = new Vector3 (-500, 0, 0);

				this.GetComponent<SpriteRenderer> ().sprite = standingRight;
			}

			if (bulletPos.x < enemyPos.x) {

				rb.velocity = new Vector3 (500, 0, 0);

				this.GetComponent<SpriteRenderer> ().sprite = standingLeft;
			}

			Invoke("changeBackToWhite", 0.75f);
		}

		if (coll.gameObject.tag == "explosion") {

			Vector3 bulletPos = new Vector3 (coll.gameObject.transform.position.x,
				coll.gameObject.transform.position.y,
				coll.gameObject.transform.position.z);

			Vector3 enemyPos = new Vector3 (this.transform.position.x,
				this.transform.position.y,
				this.transform.position.z);

			health -= 50;

			this.GetComponent<SpriteRenderer> ().color = Color.red;

			if (bulletPos.x > enemyPos.x) {

				rb.velocity = new Vector3 (-750, 0, 0);

				this.GetComponent<SpriteRenderer> ().sprite = standingRight;
			}

			if (bulletPos.x < enemyPos.x) {

				rb.velocity = new Vector3 (750, 0, 0);

				this.GetComponent<SpriteRenderer> ().sprite = standingLeft;
			}

			Invoke("changeBackToWhite", 0.75f);
		}
	}

	void changeBackToWhite(){
		this.GetComponent<SpriteRenderer> ().color = Color.white;
		rb.Sleep ();
	}
}
