using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerMove : MonoBehaviour {

	public GameObject player;

//	public GameObject playerShadow;

	Rigidbody2D rb;

	int jumpCounter;

	bool playerIsFlying;

	float moveSpeed;

	public bool screenTransition;

	float shadowMoveAmount = 0.5f;
	float shadowMoveTimer = 0;

	public bool facingLeft;
	public bool facingRight;

	bool playerIsAirborn;

	bool playerInvulnerable;

	int health;

//	public GameObject healthText;

	//textBoxMovement
	public bool canMove;

	//player ability bools
	public bool playerHasFlight;
	public bool playerHasDoubleJump;

	//player has met shadow bool
	public bool playerHasShadow;

	//player checkpoint bools
	public bool RM1Checkpoint;

	public bool RM2CheckpointL;
	public bool RM2CheckpointR;

	public bool RM3CheckpointL;
	public bool RM3CheckpointR;

	public bool RM4CheckpointL;
	public bool RM4CheckpointR;

	public bool RM5CheckpointL;
	public bool RM5CheckpointR;

	public bool RM6CheckpointL;
	public bool RM6CheckpointR;

	public bool RM7CheckpointL;
	public bool RM7CheckpointR;

	public bool RM8CheckpointL;
	public bool RM8CheckpointR;

	public bool RM9CheckpointL;
	public bool RM9CheckpointR;

	public bool RM10CheckpointL;
	public bool RM10CheckpointR;

	public bool RM11CheckpointL;
	public bool RM11CheckpointR;

	public bool RM12CheckpointL;
	public bool RM12CheckpointR;

	public bool RM13CheckpointL;
	public bool RM13CheckpointR;

	public bool RM14CheckpointL;
	public bool RM14CheckpointR;

	public bool RM15CheckpointL;
	public bool RM15CheckpointR;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();

		jumpCounter = 0;

		playerIsFlying = false;

		facingLeft = false;
		facingRight = true;

		playerIsAirborn = false;

		playerInvulnerable = false;

		screenTransition = false;

		moveSpeed = 2000f;

		health = 10;

		playerHasFlight = false;
		playerHasDoubleJump = true;

		playerHasShadow = false;

		//player checkpoint bools
		RM1Checkpoint = false;

		RM2CheckpointL = false;
		RM2CheckpointR = false;

		RM3CheckpointL = false;
		RM3CheckpointR = false;

		RM4CheckpointL = false;
		RM4CheckpointR = false;

		RM5CheckpointL = false;
		RM5CheckpointR = false;

		RM6CheckpointL = false;
		RM6CheckpointR = false;

		RM7CheckpointL = false;
		RM7CheckpointR = false;

		RM8CheckpointL = false;
		RM8CheckpointR = false;

		RM9CheckpointL = false;
		RM9CheckpointR = false;

		RM10CheckpointL = false;
		RM10CheckpointR = false;

		RM11CheckpointL = false;
		RM11CheckpointR = false;

		RM12CheckpointL = false;
		RM12CheckpointR = false;

		RM13CheckpointL = false;
		RM13CheckpointR = false;

		RM14CheckpointL = false;
		RM14CheckpointR = false;

		RM15CheckpointL = false;
		RM15CheckpointR = false;
	
	}
	
	// Update is called once per frame
	void Update () {

//		if (canMove == false) {
//			return;
//		}

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			player.transform.position.y,
			player.transform.position.z);

//		Vector3 shadowPos = new Vector3 (playerShadow.transform.position.x,
//			playerShadow.transform.position.y,
//			playerShadow.transform.position.z);

//		if (playerHasShadow == true) {
//			if (facingLeft == true) {
//				shadowPos.x = playerPos.x + 3.5f;
//			}
//
//			if (facingRight == true) {
//				shadowPos.x = playerPos.x - 3.5f;
//			}
//		}
//
//		shadowPos.y -= shadowMoveAmount * Time.deltaTime;

//		shadowMoveTimer += Time.deltaTime;
//
//		if(shadowMoveTimer >= 1) {
//			shadowMoveAmount = -shadowMoveAmount;
//			shadowMoveTimer = 0;
//		}

//		if (screenTransition == false) {
//
//			if (playerHasShadow == true) {
//				if (playerIsAirborn == true) {
//					shadowPos.y = playerPos.y + 0.5f;
//				}
//			}
//
//		}

		if (Input.GetKeyDown (KeyCode.Space) && playerIsFlying == false && playerHasDoubleJump == true) {

			jumpCounter++;

			if (jumpCounter <= 2) {

				player.GetComponent<Rigidbody2D> ().AddForce (player.transform.up * 45000f);
			}
		}

		if (Input.GetKeyDown (KeyCode.Space) && playerIsFlying == false && playerHasDoubleJump == false) {
			jumpCounter++;

			if (jumpCounter <= 1) {

				player.GetComponent<Rigidbody2D> ().AddForce (player.transform.up * 45000f);
			}
		}

		if (Input.GetKey (KeyCode.Space)) {
			playerIsAirborn = true;
		}

		//screen transitions
		if (screenTransition == true && facingRight == true) {
			playerPos.x += 50 * Time.deltaTime;
		}

		if(screenTransition == true && facingLeft == true) {
			playerPos.x -= 50 * Time.deltaTime;
		}

//		playerShadow.transform.position = shadowPos;

		//health and dying
//		Text playerHealthText = healthText.GetComponent<Text>();
//		playerHealthText.text = "Health: " + health;

		if (health <= 0) {
			Application.LoadLevel ("Dead");
		}

		if (Input.GetKeyDown (KeyCode.Return)) {
			if (RM1Checkpoint == true) {
				playerPos.x = 505;
				playerPos.y = 20;
			}

			if (RM2CheckpointL == true) {
				playerPos.x = 630;
				playerPos.y = 20;
			}

			if (RM2CheckpointR == true) {
				playerPos.x = 1162;
				playerPos.y = 170;
			}

			if (RM3CheckpointL == true) {
				playerPos.x = 1264;
				playerPos.y = 170;
			}

			if (RM3CheckpointR == true) {
				playerPos.x = 1762;
				playerPos.y = 170;
			}

			if (RM4CheckpointL == true) {
				playerPos.x = 1879;
				playerPos.y = 170;
			}
		}

		player.transform.position = playerPos;
	
	}

	void FixedUpdate () {

//		if (canMove == false) {
//			return;
//		}

		if (screenTransition == false) {

			if (Input.GetKey (KeyCode.A)) {
					
				facingLeft = true;
				facingRight = false;


				player.GetComponent<Rigidbody2D> ().AddForce (player.transform.right * -moveSpeed);

			}

			if (Input.GetKey (KeyCode.D)) {

				facingLeft = false;
				facingRight = true;


				player.GetComponent<Rigidbody2D> ().AddForce (player.transform.right * moveSpeed);

			}

//			if (playerHasFlight == true) {
//				if (Input.GetKey (KeyCode.W)) {
//					player.GetComponent<Rigidbody2D> ().drag = 10.0f;
//					playerIsFlying = true;
//					playerIsAirborn = true;
//
//					if (playerIsFlying == true) {
//						player.GetComponent<Rigidbody2D> ().AddForce (player.transform.up * 250f);
//					}
//				}
//
//				if (Input.GetKey (KeyCode.S) && playerIsFlying == true) {
//					player.GetComponent<Rigidbody2D> ().AddForce (player.transform.up * -250f);
//				}
//
//			}
//
//			if (playerHasFlight == false) {
//				player.GetComponent<Rigidbody2D> ().drag = 1.0f;
//			}
//		}
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "ground") {

			Vector3 playerPos = new Vector3 (player.transform.position.x,
				player.transform.position.y,
				player.transform.position.z);

//			Vector3 shadowPos = new Vector3 (playerShadow.transform.position.x,
//				playerShadow.transform.position.y,
//				playerShadow.transform.position.z);

			jumpCounter = 0;
			playerIsFlying = false;
			playerIsAirborn = false;

			moveSpeed = 2000f;


//			if (playerHasShadow == true) {
//				shadowPos.y = playerPos.y + 0.5f;
//			}

//			player.GetComponent<Rigidbody2D> ().drag = 1.0f;

//			playerShadow.transform.position = shadowPos;

			player.transform.position = playerPos;

			playerInvulnerable = false;
		}

		if (coll.gameObject.tag == "enemy") {

			if (playerInvulnerable == false) {

				if (facingLeft == true) {
					rb.velocity = new Vector3 (30, 30, 0);
				}

				if (facingRight == true) {
					rb.velocity = new Vector3 (-30, 30, 0);
				}

				playerIsAirborn = true;

				moveSpeed = 0;

				health -= 1;
			}

			playerInvulnerable = true;
		}

	}
}
