using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour {

	//indicate that pink death walls kill you

	//test with game club - email tonight about testing with game club on Friday

	//make it more clear that you lose an ability - have the player lose a piece of themselves

	public GameObject player;

	public GameObject playerModelFacingLeft;
	public GameObject playerModelFacingRight;
//	public GameObject playerModelCircle;
//
	Mesh playerMeshFacingLeft;
	Mesh playerMeshFacingRight;
//	Mesh playerCircleMesh;

	bool finalKey1;
	bool finalKey2;
	bool finalKey3;

	bool playFinalDoorOpeningAnimation;

//	public GameObject finalKeyA;
//	public GameObject finalKeyB;
//	public GameObject finalKeyC;

	public GameObject finalLock1;
	public GameObject finalLock2;
	public GameObject finalLock3;

	public GameObject finalDoorL;

	public GameObject finalDoorR;

	bool showFinalPortal;
	public GameObject finalPortal;

	public Material unlockedDoorLight;
	public Material unlockedDoor;

	public GameObject bossBlocker1;
	public GameObject bossBlocker2;
	public GameObject bossBlocker3;

	public GameObject bossBlocker2Z;
	public GameObject bossBlocker1Z;

	Rigidbody2D rb;

	int jumpCounter;

	bool playerIsFlying;

	float moveSpeed;
	public bool canMoveCuzNotInCutscene;

	public bool screenTransition;

	public bool facingLeft;
	public bool facingRight;

	public bool playerInvulnerable;
	float invulnerabilityCounter;

	public bool playerjustDied;

	public int health;

	bool healthRecovery;

	public bool firstPlaythrough;
	public bool secondPlaythrough;
	public bool thirdPlaythrough;
	public bool lastPlaythrough;

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

	public bool Boss1CheckpointL;
	public bool Boss1CheckpointR;

	public bool Boss2CheckpointL;
	public bool Boss2CheckpointR;

	public bool Boss3CheckpointL;
	public bool Boss3CheckpointR;

	public GameObject RM1CheckpointObject;

	public GameObject RM2CheckpointObjectL;
	public GameObject RM2CheckpointObjectR;

	public GameObject RM3CheckpointObjectL;
	public GameObject RM3CheckpointObjectR;

	public GameObject RM4CheckpointObjectL;
	public GameObject RM4CheckpointObjectR;

	public GameObject RM5CheckpointObjectL;
	public GameObject RM5CheckpointObjectR;

	public GameObject RM6CheckpointObjectL;
	public GameObject RM6CheckpointObjectR;

	public GameObject RM7CheckpointObjectL;
	public GameObject RM7CheckpointObjectR;

	public GameObject RM8CheckpointObjectL;
	public GameObject RM8CheckpointObjectR;

	public GameObject RM9CheckpointObjectL;
	public GameObject RM9CheckpointObjectR;

	public GameObject RM10CheckpointObjectL;
	public GameObject RM10CheckpointObjectR;

	public GameObject RM11CheckpointObjectL;

	public GameObject playerStart;

	public GameObject boss2R;
	public GameObject boss3R;

	public GameObject playerDeathEffect;
	public GameObject playerOutline;

	public GameObject finalKeyA;
	public GameObject finalKeyB;
	public GameObject finalKeyC;

	public GameObject emergencyKey;

	public GameObject bossBlocker3Trigger;
	public GameObject bossBlocker2Trigger;
	public GameObject bossBlocker1Trigger;

	public GameObject X;

//	public GameObject BG1;
//	public GameObject BG2;
//	public GameObject BG3;
//	public GameObject BG4;
//
//	public GameObject BG5;
//	public GameObject BG6;
//	public GameObject BG7;
//	public GameObject BG8;

	// Use this for initialization
	void Start () {

		Cursor.visible = false;

		X.SetActive (false);

		rb = GetComponent<Rigidbody2D>();

		jumpCounter = 0;

		playerIsFlying = false;

		facingLeft = false;
		facingRight = true;

		playerInvulnerable = false;
		invulnerabilityCounter = 0.0f;

		playerjustDied = false;

		screenTransition = false;

		moveSpeed = 2000f;
		canMoveCuzNotInCutscene = false;

		health = 4;

		healthRecovery = false;

		firstPlaythrough = true;
		secondPlaythrough = false;
		thirdPlaythrough = false;
		lastPlaythrough = false;

		HP1.SetActive (false);
		HP2.SetActive (false);
		HP3.SetActive (false);

		playerHasFlight = true;
		playerHasDoubleJump = true;

		playerHasKey = false;

		finalKey1 = false;
		finalKey2 = false;
		finalKey3 = false;

		showFinalPortal = false;

		playFinalDoorOpeningAnimation = false;

		finalPortal.SetActive (false);

		bossBlocker1.SetActive (false);
		bossBlocker2.SetActive (false);
		bossBlocker3.SetActive (false);

		bossBlocker2Z.SetActive (true);
		bossBlocker1Z.SetActive (true);

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

		Boss1CheckpointL = false;
		Boss1CheckpointR = false;

		Boss2CheckpointL = false;
		Boss2CheckpointR = false;

		Boss3CheckpointL = false;
		Boss3CheckpointR = false;

		emergencyKey.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

//		if (canMove == false) {
//			return;
//		}

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			player.transform.position.y,
			player.transform.position.z);

		if (facingLeft == true) {
				
			playerMeshFacingLeft = playerModelFacingLeft.GetComponent<MeshFilter>().sharedMesh;
				
			player.GetComponent<MeshFilter>().mesh = playerMeshFacingLeft;

			HP1.transform.eulerAngles = new Vector3(0, 0, 45);
			HP2.transform.eulerAngles = new Vector3(0, 0, 90);
			HP3.transform.eulerAngles = new Vector3(0, 0, 0);

			HP1.transform.localPosition = new Vector3 (-0.15f, 0.11f, -2f);
			HP2.transform.localPosition = new Vector3 (0.65f, -0.01999995f, -2f);
			HP3.transform.localPosition = new Vector3 (0f, -0.65f, -2f);
		}

		if (facingRight == true) {

			playerMeshFacingRight = playerModelFacingRight.GetComponent<MeshFilter>().sharedMesh;

			player.GetComponent<MeshFilter>().mesh = playerMeshFacingRight;

			HP1.transform.eulerAngles = new Vector3(0, 0, -45);
			HP2.transform.eulerAngles = new Vector3(0, 0, -90);
			HP3.transform.eulerAngles = new Vector3(0, 0, 0);

			HP1.transform.localPosition = new Vector3 (0.15f, 0.11f, -2f);
			HP2.transform.localPosition = new Vector3 (-0.65f, 0.01999995f, -2f);
			HP3.transform.localPosition = new Vector3 (0f, -0.65f, -2f);

		}

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

		if (health <= 0 && firstPlaythrough == true ||
		    health <= 0 && secondPlaythrough == true ||
		    health <= 0 && thirdPlaythrough == true) {

			if (RM1Checkpoint == true) {

				StartCoroutine ("FlyToCP1");

			}

			if (RM2CheckpointL == true) {

				StartCoroutine ("FlyToCP1");

			}

			if (RM2CheckpointR == true) {

				StartCoroutine ("FlyToCP1");

			}

			if (RM3CheckpointL == true) {

				StartCoroutine ("FlyToCP2R");

			}

			if (RM3CheckpointR == true) {

				StartCoroutine ("FlyToCP2R");

			}

			if (RM4CheckpointL == true) {

				StartCoroutine ("FlyToCP3R");

			}

			if (RM4CheckpointR == true) {

				StartCoroutine ("FlyToCP3R");

			}

			if (RM5CheckpointL == true) {

				StartCoroutine ("FlyToCP4R");

			}

			if (RM5CheckpointR == true) {

				StartCoroutine ("FlyToCP4R");

			}

			if (RM6CheckpointL == true) {

				StartCoroutine ("FlyToCP5R");

			}

			if (RM6CheckpointR == true) {

				StartCoroutine ("FlyToCP5R");

			}

			if (RM7CheckpointL == true) {

				StartCoroutine ("FlyToCP6R");

			}

			if (RM7CheckpointR == true) {

				StartCoroutine ("FlyToCP6R");

			}

			if (RM8CheckpointL == true) {

				StartCoroutine ("FlyToCP7R");

			}

			if (RM8CheckpointR == true) {

				StartCoroutine ("FlyToCP7R");

			}

			if (RM9CheckpointL == true) {

				StartCoroutine ("FlyToCP8R");

			}

			if (RM9CheckpointR == true) {

				StartCoroutine ("FlyToCP8R");

			}

			if (RM10CheckpointL == true) {

				StartCoroutine ("FlyToCP9R");

			}

			if (RM10CheckpointR == true) {

				StartCoroutine ("FlyToCP9R");

			}

			if (RM11CheckpointL == true ||
			   Boss1CheckpointL == true || Boss1CheckpointR == true ||
			   Boss2CheckpointL == true || Boss2CheckpointR == true ||
			   Boss3CheckpointL == true || Boss3CheckpointR == true) {

				StartCoroutine ("FlyToCP11L");
			}

			playerjustDied = true;

			health = 4;
		}

		if (health <= 0 && lastPlaythrough == true) {

			if (RM1Checkpoint == true) {

				StartCoroutine ("FlyToCP2L");

			}

			if (RM2CheckpointL == true) {

				StartCoroutine ("FlyToCP3L");

			}

			if (RM2CheckpointR == true) {

				StartCoroutine ("FlyToCP3L");

			}

			if (RM3CheckpointL == true) {

				StartCoroutine ("FlyToCP4L");

			}

			if (RM3CheckpointR == true) {

				StartCoroutine ("FlyToCP4L");

			}

			if (RM4CheckpointL == true) {

				StartCoroutine ("FlyToCP5L");

			}

			if (RM4CheckpointR == true) {

				StartCoroutine ("FlyToCP5L");

			}

			if (RM5CheckpointL == true) {

				StartCoroutine ("FlyToCP6L");

			}

			if (RM5CheckpointR == true) {

				StartCoroutine ("FlyToCP6L");

			}

			if (RM6CheckpointL == true) {

				StartCoroutine ("FlyToCP7L");

			}

			if (RM6CheckpointR == true) {

				StartCoroutine ("FlyToCP7L");

			}

			if (RM7CheckpointL == true) {

				StartCoroutine ("FlyToCP8L");

			}

			if (RM7CheckpointR == true) {

				StartCoroutine ("FlyToCP8L");

			}

			if (RM8CheckpointL == true) {

				StartCoroutine ("FlyToCP9L");

			}

			if (RM8CheckpointR == true) {

				StartCoroutine ("FlyToCP9L");

			}

			if (RM9CheckpointL == true) {

				StartCoroutine ("FlyToCP10L");

			}

			if (RM9CheckpointR == true) {

				StartCoroutine ("FlyToCP10L");

			}

			if (RM10CheckpointL == true) {

				StartCoroutine ("FlyToCP11L");

			}

			if (RM10CheckpointR == true) {

				StartCoroutine ("FlyToCP11L");

			}

			if (RM11CheckpointL == true ||
				Boss1CheckpointL == true || Boss1CheckpointR == true ||
				Boss2CheckpointL == true || Boss2CheckpointR == true ||
				Boss3CheckpointL == true || Boss3CheckpointR == true) {

				StartCoroutine ("FlyToCP11R");
			}

			playerjustDied = true;

			health = 4;
		}

		if (healthRecovery == true) {

			health = 4;
		}

//		if (Input.GetKey (KeyCode.Return) && firstPlaythrough == true || 
//			Input.GetKey (KeyCode.Return) && secondPlaythrough == true ||
//			Input.GetKey (KeyCode.Return) && thirdPlaythrough == true) {
//
//			StartCoroutine ("FlyToBoss3");
//
//			playerjustDied = true;
//		}

		if (playerjustDied == true) {
			playerInvulnerable = true;
		}

		if (playerInvulnerable == true) {

			invulnerabilityCounter += Time.deltaTime;
		}

		if (invulnerabilityCounter >= 1f) {
			playerInvulnerable = false;

			invulnerabilityCounter = 0.0f;
		}

		if (playFinalDoorOpeningAnimation == true) {

			Vector3 finalDoorLeftPos = new Vector3 (finalDoorL.transform.position.x,
				                        finalDoorL.transform.position.y,
				                        finalDoorL.transform.position.z);

			Vector3 finalDoorRightPos = new Vector3 (finalDoorR.transform.position.x,
				                         finalDoorR.transform.position.y,
				                         finalDoorR.transform.position.z);


			if (finalDoorLeftPos.x >= -334) {
				finalDoorLeftPos.x -= 10 * Time.deltaTime;
			}

			if (finalDoorRightPos.x <= -314) {
				finalDoorRightPos.x += 10 * Time.deltaTime;
			}

			if (finalDoorLeftPos.x <= -334 && finalDoorRightPos.x >= -314) {

				showFinalPortal = true;
			}

			finalDoorL.transform.position = finalDoorLeftPos;
			finalDoorR.transform.position = finalDoorRightPos;
		}

		if (showFinalPortal == true) {

			finalPortal.SetActive (true);
		}


		//DIFFERENT PLAYER MODELS
//		if(GameObject.Find ("Target").GetComponent<targetControl> ().squareWorldActive == true &&
//			screenTransition == false && RM1Checkpoint == false){
//
//			playerSquareMesh = playerModelSquare.GetComponent<MeshFilter>().sharedMesh;
//
//			player.GetComponent<MeshFilter>().mesh = playerSquareMesh;
//		}
//
//		if(GameObject.Find ("Target").GetComponent<targetControl> ().squareWorldActive == false &&
//			screenTransition == false && RM1Checkpoint == false){
//
//			playerCircleMesh = playerModelCircle.GetComponent<MeshFilter>().sharedMesh;
//
//			player.GetComponent<MeshFilter>().mesh = playerCircleMesh;
//		}
//
//		if (screenTransition == true) {
//
//			playerTriangleMesh = playerModelTriangle.GetComponent<MeshFilter>().sharedMesh;
//
//			player.GetComponent<MeshFilter>().mesh = playerTriangleMesh;
//		}
//
//		if (RM1Checkpoint == true) {
//
//			playerTriangleMesh = playerModelTriangle.GetComponent<MeshFilter>().sharedMesh;
//
//			player.GetComponent<MeshFilter>().mesh = playerTriangleMesh;
//		}

		player.transform.position = playerPos;
	
	}

	void FixedUpdate () {

//		if (canMove == false) {
//			return;
//		}

		if (Input.GetKey (KeyCode.A) == false || Input.GetKey (KeyCode.D) == false) {

			if (GameObject.Find ("BackgroundColorA") != null) {
				GameObject.Find ("BackgroundColorA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("BackgroundColorA").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("BackgroundA") != null) {
				GameObject.Find ("BackgroundA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("BackgroundA").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("MidgroundA") != null) {
				GameObject.Find ("MidgroundA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("MidgroundA").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("ForegroundA") != null) {
				GameObject.Find ("ForegroundA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("ForegroundA").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("BackgroundColorB") != null) {
				GameObject.Find ("BackgroundColorB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("BackgroundColorB").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("BackgroundB") != null) {
				GameObject.Find ("BackgroundB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("BackgroundB").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("MidgroundB") != null) {
				GameObject.Find ("MidgroundB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("MidgroundB").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("ForegroundB") != null) {
				GameObject.Find ("ForegroundB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("ForegroundB").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("BackgroundColorC") != null) {
				GameObject.Find ("BackgroundColorC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("BackgroundColorC").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("BackgroundC") != null) {
				GameObject.Find ("BackgroundC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("BackgroundC").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("MidgroundC") != null) {
				GameObject.Find ("MidgroundC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("MidgroundC").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("ForegroundC") != null) {
				GameObject.Find ("ForegroundC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("ForegroundC").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("CBackgroundColorC") != null) {
				GameObject.Find ("CBackgroundColorC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("CBackgroundColorC").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("CForegroundC") != null) {
				GameObject.Find ("CForegroundC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("CForegroundC").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("CBackgroundColorA") != null) {
				GameObject.Find ("CBackgroundColorA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("CBackgroundColorA").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("CForegroundA") != null) {
				GameObject.Find ("CForegroundA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("CForegroundA").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("CBackgroundColorB") != null) {
				GameObject.Find ("CBackgroundColorB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("CBackgroundColorB").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			if (GameObject.Find ("CForegroundB") != null) {
				GameObject.Find ("CForegroundB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 0;
				GameObject.Find ("CForegroundB").GetComponent<backGroundScrollNoRepeat> ().direction.x = 0;
			}

			this.gameObject.GetComponent<Renderer> ().material.SetFloat ("_RedrawRate", 2);
		}

		if (Input.GetKeyUp (KeyCode.Space) || Input.GetKey(KeyCode.W) == false && playerHasFlight == true) {

			this.gameObject.GetComponent<Renderer> ().material.SetFloat ("_RedrawRate", 2);
		}

		if (screenTransition == false) {

			healthRecovery = false;

			if (Input.GetKey (KeyCode.A) && canMoveCuzNotInCutscene == true) {
					
				facingLeft = true;
				facingRight = false;

				if (GameObject.Find ("BackgroundColorA") != null) {
					GameObject.Find ("BackgroundColorA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 5;
					GameObject.Find ("BackgroundColorA").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("BackgroundA") != null) {
					GameObject.Find ("BackgroundA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 6;
					GameObject.Find ("BackgroundA").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("MidgroundA") != null) {
					GameObject.Find ("MidgroundA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 6;
					GameObject.Find ("MidgroundA").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("ForegroundA") != null) {
					GameObject.Find ("ForegroundA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 7;
					GameObject.Find ("ForegroundA").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("BackgroundColorB") != null) {
					GameObject.Find ("BackgroundColorB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 5;
					GameObject.Find ("BackgroundColorB").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("BackgroundB") != null) {
					GameObject.Find ("BackgroundB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 6;
					GameObject.Find ("BackgroundB").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("MidgroundB") != null) {
					GameObject.Find ("MidgroundB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 6;
					GameObject.Find ("MidgroundB").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("ForegroundB") != null) {
					GameObject.Find ("ForegroundB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 7;
					GameObject.Find ("ForegroundB").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("BackgroundColorC") != null) {
					GameObject.Find ("BackgroundColorC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 5;
					GameObject.Find ("BackgroundColorC").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("BackgroundC") != null) {
					GameObject.Find ("BackgroundC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 6;
					GameObject.Find ("BackgroundC").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("MidgroundC") != null) {
					GameObject.Find ("MidgroundC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 6;
					GameObject.Find ("MidgroundC").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("ForegroundC") != null) {
					GameObject.Find ("ForegroundC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 7;
					GameObject.Find ("ForegroundC").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("CBackgroundColorC") != null) {
					GameObject.Find ("CBackgroundColorC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 5;
					GameObject.Find ("CBackgroundColorC").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("CForegroundC") != null) {
					GameObject.Find ("CForegroundC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 7;
					GameObject.Find ("CForegroundC").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("CBackgroundColorA") != null) {
					GameObject.Find ("CBackgroundColorA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 5;
					GameObject.Find ("CBackgroundColorA").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("CForegroundA") != null) {
					GameObject.Find ("CForegroundA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 7;
					GameObject.Find ("CForegroundA").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("CBackgroundColorB") != null) {
					GameObject.Find ("CBackgroundColorB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 5;
					GameObject.Find ("CBackgroundColorB").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				if (GameObject.Find ("CForegroundB") != null) {
					GameObject.Find ("CForegroundB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 7;
					GameObject.Find ("CForegroundB").GetComponent<backGroundScrollNoRepeat> ().direction.x = -1;
				}

				this.gameObject.GetComponent<Renderer> ().material.SetFloat ("_RedrawRate", 30);


				player.GetComponent<Rigidbody2D> ().AddForce (player.transform.right * -moveSpeed);

			} 

			if (Input.GetKey (KeyCode.D) && canMoveCuzNotInCutscene == true) {

				facingLeft = false;
				facingRight = true;

				if (GameObject.Find ("BackgroundColorA") != null) {
					GameObject.Find ("BackgroundColorA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 5;
					GameObject.Find ("BackgroundColorA").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("BackgroundA") != null) {
					GameObject.Find ("BackgroundA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 6;
					GameObject.Find ("BackgroundA").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("MidgroundA") != null) {
					GameObject.Find ("MidgroundA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 6;
					GameObject.Find ("MidgroundA").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("ForegroundA") != null) {
					GameObject.Find ("ForegroundA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 7;
					GameObject.Find ("ForegroundA").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("BackgroundColorB") != null) {
					GameObject.Find ("BackgroundColorB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 5;
					GameObject.Find ("BackgroundColorB").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("BackgroundB") != null) {
					GameObject.Find ("BackgroundB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 6;
					GameObject.Find ("BackgroundB").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("MidgroundB") != null) {
					GameObject.Find ("MidgroundB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 6;
					GameObject.Find ("MidgroundB").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("ForegroundB") != null) {
					GameObject.Find ("ForegroundB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 7;
					GameObject.Find ("ForegroundB").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("BackgroundColorC") != null) {
					GameObject.Find ("BackgroundColorC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 5;
					GameObject.Find ("BackgroundColorC").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("BackgroundC") != null) {
					GameObject.Find ("BackgroundC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 6;
					GameObject.Find ("BackgroundC").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("MidgroundC") != null) {
					GameObject.Find ("MidgroundC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 6;
					GameObject.Find ("MidgroundC").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("ForegroundC") != null) {
					GameObject.Find ("ForegroundC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 7;
					GameObject.Find ("ForegroundC").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("CBackgroundColorC") != null) {
					GameObject.Find ("CBackgroundColorC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 5;
					GameObject.Find ("CBackgroundColorC").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("CForegroundC") != null) {
					GameObject.Find ("CForegroundC").GetComponent<backGroundScrollNoRepeat> ().speed.x = 7;
					GameObject.Find ("CForegroundC").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("CBackgroundColorA") != null) {
					GameObject.Find ("CBackgroundColorA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 5;
					GameObject.Find ("CBackgroundColorA").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("CForegroundA") != null) {
					GameObject.Find ("CForegroundA").GetComponent<backGroundScrollNoRepeat> ().speed.x = 7;
					GameObject.Find ("CForegroundA").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("CBackgroundColorB") != null) {
					GameObject.Find ("CBackgroundColorB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 5;
					GameObject.Find ("CBackgroundColorB").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}

				if (GameObject.Find ("CForegroundB") != null) {
					GameObject.Find ("CForegroundB").GetComponent<backGroundScrollNoRepeat> ().speed.x = 7;
					GameObject.Find ("CForegroundB").GetComponent<backGroundScrollNoRepeat> ().direction.x = 1;
				}


				this.gameObject.GetComponent<Renderer> ().material.SetFloat ("_RedrawRate", -30);


				player.GetComponent<Rigidbody2D> ().AddForce (player.transform.right * moveSpeed);

			}

			if (Input.GetKeyDown (KeyCode.Space) && canMoveCuzNotInCutscene == true) {
				this.gameObject.GetComponent<Renderer> ().material.SetFloat ("_RedrawRate", 30);
			}

			if (playerHasFlight == true) {
				if (Input.GetKey (KeyCode.W) && canMoveCuzNotInCutscene == true) {
					playerIsFlying = true;
					this.gameObject.GetComponent<Renderer> ().material.SetFloat ("_RedrawRate", 30);

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

			Vector3 playerPosRN = new Vector3 (this.transform.position.x,
				                      this.transform.position.y,
				                      this.transform.position.z);

			Vector3 enemyPosRN = new Vector3 (coll.gameObject.transform.position.x,
				                     coll.gameObject.transform.position.y,
				                     coll.gameObject.transform.position.z);

			playerHasKey = false;

			if (playerInvulnerable == false) {

				if (enemyPosRN.x > playerPosRN.x) {
					rb.velocity = new Vector3 (-750, 750, 0);
				}

				if (enemyPosRN.x < playerPosRN.x) {
					rb.velocity = new Vector3 (750, 750, 0);
				}

				this.transform.position = playerPosRN;
				coll.gameObject.transform.position = enemyPosRN;

				health -= 1;
			}

			playerInvulnerable = true;
		}

		if (coll.gameObject.tag == "boss") {

			Vector3 playerPosRN = new Vector3 (this.transform.position.x,
				this.transform.position.y,
				this.transform.position.z);

			Vector3 enemyPosRN = new Vector3 (coll.gameObject.transform.position.x,
				coll.gameObject.transform.position.y,
				coll.gameObject.transform.position.z);

			playerHasKey = false;

			if (playerInvulnerable == false) {

				if (enemyPosRN.x > playerPosRN.x) {
					rb.velocity = new Vector3 (-1500, 750, 0);
				}

				if (enemyPosRN.x < playerPosRN.x) {
					rb.velocity = new Vector3 (1500, 750, 0);
				}

				this.transform.position = playerPosRN;
				coll.gameObject.transform.position = enemyPosRN;

				health -= 1;
			}

			playerInvulnerable = true;

		}

		if (coll.gameObject.tag == "deathWall") {

			Vector3 playerPosRN = new Vector3 (this.transform.position.x,
				this.transform.position.y,
				this.transform.position.z);

			Vector3 deathWallPosRN = new Vector3 (coll.gameObject.transform.position.x,
				coll.gameObject.transform.position.y,
				coll.gameObject.transform.position.z);

			if (deathWallPosRN.x > playerPosRN.x) {
				rb.velocity = new Vector3 (-750, 750, 0);
			}

			if (deathWallPosRN.x < playerPosRN.x) {
				rb.velocity = new Vector3 (750, 750, 0);
			}

			this.transform.position = playerPosRN;
			coll.gameObject.transform.position = deathWallPosRN;

			playerHasKey = false;

			health = 0;

		}

		if (coll.gameObject.tag == "finalKey1" && finalKey1 == false) {

			StartCoroutine ("FlyToPlayerStart");

			finalKeyA.SetActive (false);

			bossBlocker3.SetActive (false);

			bossBlocker3Trigger.SetActive (false);

			finalKey1 = true;

			RM1Checkpoint = true;

			playerHasFlight = false;

			firstPlaythrough = false;
			secondPlaythrough = true;
			thirdPlaythrough = false;
			lastPlaythrough = false;

			bossBlocker2Z.SetActive (false);

			finalLock1.GetComponent<Renderer> ().material = unlockedDoorLight;

			player.transform.position = playerPos;

		} 

		if (coll.gameObject.tag == "finalKey2" && finalKey2 == false) {

			StartCoroutine ("FlyToPlayerStart");

			finalKeyB.SetActive (false);

			bossBlocker2.SetActive (false);

			bossBlocker2Trigger.SetActive (false);

			finalKey2 = true;

			RM1Checkpoint = true;

			playerHasDoubleJump = false;

			firstPlaythrough = false;
			secondPlaythrough = false;
			thirdPlaythrough = true;
			lastPlaythrough = false;

			bossBlocker1Z.SetActive (false);

			finalLock2.GetComponent<Renderer> ().material = unlockedDoorLight;

			player.transform.position = playerPos;

		} 

		if (coll.gameObject.tag == "finalKey3" && finalKey3 == false) {

			finalKey3 = true;

			finalKeyC.SetActive (false);

			emergencyKey.SetActive (true);

			bossBlocker1.SetActive (false);

			bossBlocker1Trigger.SetActive (false);

//			GameObject.Find ("Target").GetComponent<targetControl> ().playerCanSwitchWorlds = false;

			GameObject.Find ("Target").GetComponent<targetControl> ().playerHasMG = false;

			X.SetActive (true);

			GameObject.Find ("Target").GetComponent<targetControl> ().MLEquipped = true;
			GameObject.Find ("Target").GetComponent<targetControl> ().AREquipped = false;

//			moveSpeed = 20;

			firstPlaythrough = false;
			secondPlaythrough = false;
			thirdPlaythrough = false;
			lastPlaythrough = true;

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

		if (coll.gameObject.tag == "teleportToBoss3") {
			playerPos.x = 6605;
			playerPos.y = 3020;
		}

		if (coll.gameObject.tag == "teleportBack3") {
			playerPos.x = 6047;
			playerPos.y = 2079;
		}

		if (coll.gameObject.tag == "Boss3") {

			bossBlocker3.SetActive (true);
		}

		if (coll.gameObject.tag == "teleportToBoss2") {
			playerPos.x = 6605;
			playerPos.y = 2021;
		}

		if (coll.gameObject.tag == "teleportBack2") {
			playerPos.x = 6047;
			playerPos.y = 1924;
		}

		if (coll.gameObject.tag == "Boss2") {

			bossBlocker2.SetActive (true);
		}

		if (coll.gameObject.tag == "teleportToBoss1") {
			playerPos.x = 6605;
			playerPos.y = 1020;
		}

		if (coll.gameObject.tag == "teleportBack1") {
			playerPos.x = 6047;
			playerPos.y = 1769;
		}

		if (coll.gameObject.tag == "Boss1") {

			bossBlocker1.SetActive (true);
		}

		if (coll.gameObject.tag == "transitionEnd") {
			bossBlocker3.SetActive (false);
			bossBlocker2.SetActive (false);
			bossBlocker1.SetActive (false);
		}

		if (coll.gameObject.tag == "finalDoorTrigger" && finalKey3 == true) {

			playFinalDoorOpeningAnimation = true;
		}

		if (coll.gameObject.tag == "finalPortal") {
			SceneManager.LoadSceneAsync("TriangleWorld", LoadSceneMode.Single);
		}

		player.transform.position = playerPos;

	}

	//RESPAWN COROUTINES

	IEnumerator FlyToPlayerStart () {

		while (Vector3.Distance(player.transform.position, playerStart.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, playerStart.transform.position, 1000f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP1 () {

		while (Vector3.Distance(player.transform.position, RM1CheckpointObject.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;
			
			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM1CheckpointObject.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP2L () {

		while (Vector3.Distance(player.transform.position, RM2CheckpointObjectL.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM2CheckpointObjectL.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP2R () {

		while (Vector3.Distance(player.transform.position, RM2CheckpointObjectR.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM2CheckpointObjectR.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP3L () {

		while (Vector3.Distance(player.transform.position, RM3CheckpointObjectL.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM3CheckpointObjectL.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP3R () {

		while (Vector3.Distance(player.transform.position, RM3CheckpointObjectR.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM3CheckpointObjectR.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP4L () {

		while (Vector3.Distance(player.transform.position, RM4CheckpointObjectL.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM4CheckpointObjectL.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP4R () {

		while (Vector3.Distance(player.transform.position, RM4CheckpointObjectR.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM4CheckpointObjectR.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP5L () {

		while (Vector3.Distance(player.transform.position, RM5CheckpointObjectL.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM5CheckpointObjectL.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP5R () {

		while (Vector3.Distance(player.transform.position, RM5CheckpointObjectR.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM5CheckpointObjectR.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP6L () {

		while (Vector3.Distance(player.transform.position, RM6CheckpointObjectL.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM6CheckpointObjectL.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP6R () {

		while (Vector3.Distance(player.transform.position, RM6CheckpointObjectR.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM6CheckpointObjectR.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP7L () {

		while (Vector3.Distance(player.transform.position, RM7CheckpointObjectL.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM7CheckpointObjectL.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP7R () {

		while (Vector3.Distance(player.transform.position, RM7CheckpointObjectR.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM7CheckpointObjectR.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP8L () {

		while (Vector3.Distance(player.transform.position, RM8CheckpointObjectL.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM8CheckpointObjectL.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP8R () {

		while (Vector3.Distance(player.transform.position, RM8CheckpointObjectR.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM8CheckpointObjectR.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP9L () {

		while (Vector3.Distance(player.transform.position, RM9CheckpointObjectL.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM9CheckpointObjectL.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP9R () {

		while (Vector3.Distance(player.transform.position, RM9CheckpointObjectR.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM9CheckpointObjectR.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP10L () {

		while (Vector3.Distance(player.transform.position, RM10CheckpointObjectL.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM10CheckpointObjectL.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP10R () {

		while (Vector3.Distance(player.transform.position, RM10CheckpointObjectR.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM10CheckpointObjectR.transform.position, 500f * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToCP11L () {

		while (Vector3.Distance(player.transform.position, RM11CheckpointObjectL.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, RM11CheckpointObjectL.transform.position, 500 * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToBoss2 () {

		while (Vector3.Distance(player.transform.position, boss2R.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, boss2R.transform.position, 1000 * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}

	IEnumerator FlyToBoss3 () {

		while (Vector3.Distance(player.transform.position, boss3R.transform.position) > 1f) {

			player.GetComponent<Renderer> ().enabled = false;
			playerOutline.GetComponent<Renderer> ().enabled = false;

			Instantiate (playerDeathEffect, player.transform.position, player.transform.rotation);
			playerDeathEffect.transform.position = player.transform.position;

			canMoveCuzNotInCutscene = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;

			player.GetComponent<Collider2D> ().enabled = false;
			player.GetComponent<Rigidbody2D> ().gravityScale = 0.0f;

			transform.position = Vector3.MoveTowards(transform.position, boss3R.transform.position, 1000 * Time.deltaTime);

			yield return null;
		}

		player.GetComponent<Renderer> ().enabled = true;
		playerOutline.GetComponent<Renderer> ().enabled = true;

		canMoveCuzNotInCutscene = true;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;

		player.GetComponent<Collider2D> ().enabled = true;
		player.GetComponent<Rigidbody2D> ().gravityScale = 175f;
	}
}
