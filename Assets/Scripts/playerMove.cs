using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerMove : MonoBehaviour {

	//indicate that pink death walls kill you
	//test with a lot of people
	//screen share on skype - test with people

	//test with game club - email tonight about testing with game club on Friday

	//"why am I changing?"

	//make it more clear that you lose an ability - have the player lose a piece of themselves

	public GameObject player;

	public GameObject playerModelTriangle;
	public GameObject playerModelSquare;
	public GameObject playerModelCircle;

	Mesh playerTriangleMesh;
	Mesh playerSquareMesh;
	Mesh playerCircleMesh;

	bool finalKey1;
	bool finalKey2;
	bool finalKey3;

	public GameObject finalKey;

	public GameObject finalLock1;
	public GameObject finalLock2;
	public GameObject finalLock3;

	public GameObject finalDoorL;

	public GameObject finalDoorR;

	public Material unlockedDoorLight;
	public Material unlockedDoor;

	Rigidbody2D rb;

	int jumpCounter;

	bool playerIsFlying;

	float moveSpeed;

	public bool screenTransition;

	public bool facingLeft;
	public bool facingRight;

	public bool playerInvulnerable;

	public bool playerjustDied;

	public int health;

	bool healthRecovery;

	public bool normalProgress;

	public bool playerHasKey;

	public GameObject HP1;
	public GameObject HP2;
	public GameObject HP3;

	//textBoxMovement
	public bool canMove;

	//player ability bools
	public bool playerHasFlight;
	public bool playerHasDoubleJump;

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

		playerInvulnerable = false;

		playerjustDied = false;

		screenTransition = false;

		moveSpeed = 2000f;

		health = 4;

		healthRecovery = false;

		normalProgress = true;

		HP1.SetActive (false);
		HP2.SetActive (false);
		HP3.SetActive (false);

		playerHasFlight = true;
		playerHasDoubleJump = true;

		playerHasKey = false;

		finalKey1 = false;
		finalKey2 = false;
		finalKey3 = false;

		//player checkpoint bools
		RM1Checkpoint = true;

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

		//screen transitions
		if (screenTransition == true && facingRight == true) {
			playerPos.x += 50 * Time.deltaTime;
			playerHasKey = false;
			playerjustDied = false;
			healthRecovery = true;
		}

		if(screenTransition == true && facingLeft == true) {
			playerPos.x -= 50 * Time.deltaTime;
			playerHasKey = false;
			playerjustDied = false;
			healthRecovery = true;
		}

		//health and dying

		if (health == 4) {
			
			HP1.SetActive (false);
			HP2.SetActive (false);
			HP3.SetActive (false);

			rb.isKinematic = false;
		}

		if (health == 3) {

			HP1.SetActive (true);
			HP2.SetActive (false);
			HP3.SetActive (false);
		}

		if (health == 2) {

			HP1.SetActive (true);
			HP2.SetActive (true);
			HP3.SetActive (false);
		}

		if (health == 1) {

			HP1.SetActive (true);
			HP2.SetActive (true);
			HP3.SetActive (true);
		}

		if (health <= 0 && normalProgress == true) {

			rb.isKinematic = true;

			if (RM1Checkpoint == true) {
				playerPos.x = 505;
				playerPos.y = 20;
			}

			if (RM2CheckpointL == true) {
				playerPos.x = 505;
				playerPos.y = 20;
			}

			if (RM2CheckpointR == true) {
				playerPos.x = 505;
				playerPos.y = 20;
			}

			if (RM3CheckpointL == true) {
				playerPos.x = 1162;
				playerPos.y = 170;
			}

			if (RM3CheckpointR == true) {
				playerPos.x = 1162;
				playerPos.y = 170;
			}

			if (RM4CheckpointL == true) {
				playerPos.x = 1762;
				playerPos.y = 170;
			}

			if (RM4CheckpointR == true) {
				playerPos.x = 1762;
				playerPos.y = 170;
			}

			if (RM5CheckpointL == true) {
				playerPos.x = 2419;
				playerPos.y = 170;
			}

			if (RM5CheckpointR == true) {
				playerPos.x = 2419;
				playerPos.y = 170;
			}

			if (RM6CheckpointL == true) {
				playerPos.x = 3212;
				playerPos.y = 170;
			}

			if (RM6CheckpointR == true) {
				playerPos.x = 3212;
				playerPos.y = 170;
			}

			if (RM7CheckpointL == true) {
				playerPos.x = 3615;
				playerPos.y = 771;
			}

			if (RM7CheckpointR == true) {
				playerPos.x = 3615;
				playerPos.y = 771;
			}

			if (RM8CheckpointL == true) {
				playerPos.x = 3714;
				playerPos.y = 1119;
			}

			if (RM8CheckpointR == true) {
				playerPos.x = 3714;
				playerPos.y = 1119;
			}

			if (RM9CheckpointL == true) {
				playerPos.x = 3618;
				playerPos.y = 1769;
			}

			if (RM9CheckpointR == true) {
				playerPos.x = 3618;
				playerPos.y = 1769;
			}

			if (RM10CheckpointL == true) {
				playerPos.x = 4565;
				playerPos.y = 1770;
			}

			if (RM10CheckpointR == true) {
				playerPos.x = 4565;
				playerPos.y = 1770;
			}

			playerjustDied = true;

			health = 4;
		}

		if (healthRecovery == true) {

			health = 4;
		}

		if (Input.GetKeyDown (KeyCode.Return) && normalProgress == true) {

			if (RM1Checkpoint == true) {
				playerPos.x = 505;
				playerPos.y = 20;
			}

			if (RM2CheckpointL == true) {
				playerPos.x = 505;
				playerPos.y = 20;
			}

			if (RM2CheckpointR == true) {
				playerPos.x = 505;
				playerPos.y = 20;
			}

			if (RM3CheckpointL == true) {
				playerPos.x = 1162;
				playerPos.y = 170;
			}

			if (RM3CheckpointR == true) {
				playerPos.x = 1162;
				playerPos.y = 170;
			}

			if (RM4CheckpointL == true) {
				playerPos.x = 1762;
				playerPos.y = 170;
			}

			if (RM4CheckpointR == true) {
				playerPos.x = 1762;
				playerPos.y = 170;
			}

			if (RM5CheckpointL == true) {
				playerPos.x = 2419;
				playerPos.y = 170;
			}

			if (RM5CheckpointR == true) {
				playerPos.x = 2419;
				playerPos.y = 170;
			}

			if (RM6CheckpointL == true) {
				playerPos.x = 3212;
				playerPos.y = 170;
			}

			if (RM6CheckpointR == true) {
				playerPos.x = 3212;
				playerPos.y = 170;
			}

			if (RM7CheckpointL == true) {
				playerPos.x = 3615;
				playerPos.y = 771;
			}

			if (RM7CheckpointR == true) {
				playerPos.x = 3615;
				playerPos.y = 771;
			}

			if (RM8CheckpointL == true) {
				playerPos.x = 3714;
				playerPos.y = 1119;
			}

			if (RM8CheckpointR == true) {
				playerPos.x = 3714;
				playerPos.y = 1119;
			}

			if (RM9CheckpointL == true) {
				playerPos.x = 3618;
				playerPos.y = 1769;
			}

			if (RM9CheckpointR == true) {
				playerPos.x = 3618;
				playerPos.y = 1769;
			}

			if (RM10CheckpointL == true) {
				playerPos.x = 4565;
				playerPos.y = 1770;
			}

			if (RM10CheckpointR == true) {
				playerPos.x = 4565;
				playerPos.y = 1770;
			}

			playerjustDied = true;
		}

		if (playerjustDied == true) {
			playerInvulnerable = true;
		}


		//DIFFERENT PLAYER MODELS
		if(GameObject.Find ("Target").GetComponent<targetControl> ().squareWorldActive == true &&
			screenTransition == false && RM1Checkpoint == false){

			playerSquareMesh = playerModelSquare.GetComponent<MeshFilter>().sharedMesh;

			player.GetComponent<MeshFilter>().mesh = playerSquareMesh;
		}

		if(GameObject.Find ("Target").GetComponent<targetControl> ().squareWorldActive == false &&
			screenTransition == false && RM1Checkpoint == false){

			playerCircleMesh = playerModelCircle.GetComponent<MeshFilter>().sharedMesh;

			player.GetComponent<MeshFilter>().mesh = playerCircleMesh;
		}

		if (screenTransition == true) {

			playerTriangleMesh = playerModelTriangle.GetComponent<MeshFilter>().sharedMesh;

			player.GetComponent<MeshFilter>().mesh = playerTriangleMesh;
		}

		if (RM1Checkpoint == true) {

			playerTriangleMesh = playerModelTriangle.GetComponent<MeshFilter>().sharedMesh;

			player.GetComponent<MeshFilter>().mesh = playerTriangleMesh;
		}

		player.transform.position = playerPos;
	
	}

	void FixedUpdate () {

//		if (canMove == false) {
//			return;
//		}

		if (screenTransition == false) {

			healthRecovery = false;

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

			if (playerHasFlight == true) {
				if (Input.GetKey (KeyCode.W)) {
					playerIsFlying = true;

					if (playerIsFlying == true) {
						player.GetComponent<Rigidbody2D> ().AddForce (player.transform.up * 4000f);
					}
				}

			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll){

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			player.transform.position.y,
			player.transform.position.z);

		if (coll.gameObject.tag == "ground") {

			jumpCounter = 0;
			playerIsFlying = false;

			moveSpeed = 2000f;

			player.transform.position = playerPos;

			if (playerjustDied == false) {
				playerInvulnerable = false;
			}
		}

		if (coll.gameObject.tag == "key") {
			
			playerHasKey = true;
		}

		if (coll.gameObject.tag == "enemy") {

			playerHasKey = false;

			if (playerInvulnerable == false) {

				if (facingLeft == true) {
					rb.velocity = new Vector3 (750, 750, 0);
				}

				if (facingRight == true) {
					rb.velocity = new Vector3 (-750, 750, 0);
				}

				moveSpeed = 0;

				health -= 1;
			}

			playerInvulnerable = true;
		}

		if (coll.gameObject.tag == "deathWall") {

			playerHasKey = false;

			health = 0;

		}

		if (coll.gameObject.tag == "finalKey" && finalKey1 == false) {

			playerPos.x = -40;
			playerPos.y = 19.35f;

			finalKey1 = true;

			RM1Checkpoint = true;

			playerHasFlight = false;

			finalLock1.GetComponent<Renderer> ().material = unlockedDoorLight;

			player.transform.position = playerPos;

		} else if (coll.gameObject.tag == "finalKey" && finalKey2 == false) {

			playerPos.x = -40;
			playerPos.y = 19.35f;

			finalKey2 = true;

			RM1Checkpoint = true;

			finalLock2.GetComponent<Renderer> ().material = unlockedDoorLight;

			player.transform.position = playerPos;

		} else if (coll.gameObject.tag == "finalKey" && finalKey3 == false) {

			playerPos.x = -40;
			playerPos.y = 19.35f;

			finalKey3 = true;

			RM1Checkpoint = true;

			finalLock3.GetComponent<Renderer> ().material = unlockedDoorLight;

			finalDoorL.GetComponent<Renderer> ().material = unlockedDoor;

			finalDoorR.GetComponent<Renderer> ().material = unlockedDoor;

			player.transform.position = playerPos;

		}

	}

	void OnTriggerEnter2D(Collider2D coll) {

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			player.transform.position.y,
			player.transform.position.z);

		if (coll.gameObject.tag == "wall") {
			if (RM5CheckpointL == true) {
				playerPos.x = 2513;
				playerPos.y = 170;
			}

			if (RM5CheckpointR == true) {
				playerPos.x = 3212;
				playerPos.y = 170;
			}

			if (RM6CheckpointL == true) {
				playerPos.x = 3326;
				playerPos.y = 170;
			}

			if (RM6CheckpointR == true) {
				playerPos.x = 3615;
				playerPos.y = 771;
			}
		}

		if (coll.gameObject.tag == "teleportToBoss") {
			playerPos.x = 56;
			playerPos.y = -2977;
		}

		player.transform.position = playerPos;

	}
}
