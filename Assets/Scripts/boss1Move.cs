using UnityEngine;
using System.Collections;

public class boss1Move : MonoBehaviour {

	public GameObject player;

	Rigidbody2D rb;

	bool touchingGround;

	float jumpCounter = 0f;

	int health;

	public Sprite standingLeft;
	public Sprite standingRight;
	public Sprite jumpingLeft;
	public Sprite jumpingRight;

	public GameObject specialLava1;
	public GameObject specialLava2;
	public GameObject specialLava3;

	bool timeToSpawnMinions;

	public GameObject finalKey1;
	public GameObject finalKey2;
	public GameObject finalKey3;

	// Use this for initialization
	void Start () {

		finalKey1 = GameObject.Find ("TriangleKey1");
		finalKey3 = GameObject.Find ("TriangleKey3");

		timeToSpawnMinions = false;

		player = GameObject.Find ("Player");

		rb = GetComponent<Rigidbody2D>();

		touchingGround = true;

		health = 500;
	
	}
	
	// Update is called once per frame
	void Update () {


		if (finalKey1 != null) {
			Physics2D.IgnoreCollision (finalKey1.GetComponent<Collider2D> (), this.GetComponent<Collider2D> ());
		}
		Physics2D.IgnoreCollision (finalKey3.GetComponent<Collider2D> (), this.GetComponent<Collider2D> ());

		Vector3 enemyPos = new Vector3 (this.transform.position.x,
			this.transform.position.y,
			this.transform.position.z);

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			player.transform.position.y,
			player.transform.position.z);

		if (Vector3.Distance (this.transform.position, player.transform.position) < 400f) {
			if (touchingGround == true) {

				jumpCounter += Time.deltaTime;

				if (jumpCounter > 1f) {

					timeToSpawnMinions = true;

					rb.velocity = new Vector3 (0, 1200, 0);

					touchingGround = false;

					jumpCounter = 0.0f;

					if (enemyPos.x < playerPos.x) {
						this.GetComponent<SpriteRenderer> ().sprite = jumpingRight;
					}

					if (enemyPos.x > playerPos.x) {
						this.GetComponent<SpriteRenderer> ().sprite = jumpingLeft;
					}
				}
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
	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "ground") {

			Vector3 playerPos = new Vector3 (player.transform.position.x,
				player.transform.position.y,
				player.transform.position.z);

			Vector3 enemyPos = new Vector3 (this.transform.position.x,
				this.transform.position.y,
				this.transform.position.z);

			if (timeToSpawnMinions == true) {

				GameObject specialLavaClone1 = (GameObject)Instantiate (specialLava1);

				GameObject specialLavaClone2 = (GameObject)Instantiate (specialLava2);

				GameObject specialLavaClone3 = (GameObject)Instantiate (specialLava3);

				timeToSpawnMinions = false;

				Vector3 clonePos1 = new Vector3 (specialLavaClone1.transform.position.x,
					                   specialLavaClone1.transform.position.y,
					                   specialLavaClone1.transform.position.z);

				Vector3 clonePos2 = new Vector3 (specialLavaClone2.transform.position.x,
					                   specialLavaClone2.transform.position.y,
					                   specialLavaClone2.transform.position.z);

				Vector3 clonePos3 = new Vector3 (specialLavaClone3.transform.position.x,
					                   specialLavaClone3.transform.position.y,
					                   specialLavaClone3.transform.position.z);

				clonePos1.x = enemyPos.x - Random.Range(50, 110);
				clonePos1.y = enemyPos.y + 115;
				specialLavaClone1.transform.position = clonePos1;

				clonePos2.x = enemyPos.x - Random.Range(150, 210);
				clonePos2.y = enemyPos.y + 115;
				specialLavaClone2.transform.position = clonePos2;

				clonePos3.x = enemyPos.x - Random.Range(250, 310);
				clonePos3.y = enemyPos.y + 115;
				specialLavaClone3.transform.position = clonePos3;

				Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), specialLavaClone1.GetComponent<Collider2D> ());

				Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), specialLavaClone2.GetComponent<Collider2D> ());

				Physics2D.IgnoreCollision (this.GetComponent<Collider2D> (), specialLavaClone3.GetComponent<Collider2D> ());
			}

			if (playerPos.x > enemyPos.x) {
				this.GetComponent<SpriteRenderer> ().sprite = standingRight;
			}

			if (playerPos.x < enemyPos.x) {
				this.GetComponent<SpriteRenderer> ().sprite = standingLeft;
			}

			touchingGround = true;
		}

		if (coll.gameObject.tag == "ARbullet") {
			
			health -= 10;

			this.GetComponent<SpriteRenderer> ().color = Color.green;

			Invoke("changeBackToWhite", 0.15f);
		}

		if (coll.gameObject.tag == "SGbullet") {
			
			health -= 25;

			this.GetComponent<SpriteRenderer> ().color = Color.green;

			Invoke("changeBackToWhite", 0.15f);
		}

		if (coll.gameObject.tag == "explosion") {
			
			health -= 50;

			this.GetComponent<SpriteRenderer> ().color = Color.green;

			Invoke("changeBackToWhite", 0.15f);
		}
	
	}

	void changeBackToWhite(){
		this.GetComponent<SpriteRenderer> ().color = Color.white;
	}
}
