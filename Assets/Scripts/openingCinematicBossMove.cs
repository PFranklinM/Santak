using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class openingCinematicBossMove : MonoBehaviour {

	public GameObject player;

	float moveSpeed;

	bool timeToMoveRight;
	bool realization;
	bool timeToMoveLeft;

	bool playerShouldStepForward;

	bool timeToFade;

	public bool cameraShouldFollow;

	public Material newMat;

	Material mat;
	Color colorA;

	// Use this for initialization
	void Start () {

		moveSpeed = 85;

		timeToMoveRight = false;
		realization = false;
		timeToMoveLeft = false;

		playerShouldStepForward = false;

		cameraShouldFollow = false;

		timeToFade = false;

		colorA.a = 1;
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 bossMove = new Vector3 (transform.position.x,
			                   transform.position.y,
			                   transform.position.z);

		Vector3 playerMove = new Vector3 (player.transform.position.x,
								player.transform.position.y,
								player.transform.position.z);

		if (bossMove.y <= -90) {
			bossMove.y += moveSpeed * Time.deltaTime;
		}

		if (bossMove.y >= -90 && realization == false) {
			timeToMoveRight = true;

			cameraShouldFollow = true;
		}

		if (timeToMoveRight == true) {
			bossMove.x += moveSpeed * Time.deltaTime;
		}

		if (realization == true) {
			Invoke ("goBackLeft", 2f);
		}

		if(timeToMoveLeft == true && bossMove.x >= 621.5f) {

			bossMove.x -= 500f * Time.deltaTime;
		}

		if (timeToMoveLeft == true && bossMove.x <= 622f) {
			bossMove.x = 621;

			Invoke ("playerStepForward", 1.75f);
		}

		if (playerShouldStepForward == true && playerMove.y >= 0f) {

			playerMove.y -= moveSpeed * Time.deltaTime;
		}

		if (playerShouldStepForward == true && playerMove.y <= 0.5f) {
			playerMove.y = 0;
		}

		if (GameObject.Find ("BossTextBoxManger").GetComponent<bossTextBoxManagerOpening> ().isActive == false) {
			timeToFade = true;
		}

		if (timeToFade == true) {
			player.gameObject.GetComponent<Renderer>().material = newMat;

			newMat = player.GetComponent<Renderer> ().material;

			colorA = newMat.color;
			colorA.a -= 0.75f * Time.deltaTime;

			//		mat.SetColor ("_EmissionColor", colorA);
			newMat.SetColor ("_Color", colorA);
			newMat.SetColor ("_TintColor", colorA);
		}

		if (colorA.a <= 0.0001) {

			Invoke ("loadMainGame", 0.5f);
		}

		transform.position = bossMove;

		player.transform.position = playerMove;
	
	}

	void OnTriggerEnter2D(Collider2D coll) {

		if (coll.gameObject.tag == "realizationTrigger") {
			timeToMoveRight = false;
			realization = true;
		}
	}

	void goBackLeft() {
		timeToMoveLeft = true;
	}

	void playerStepForward() {
		playerShouldStepForward = true;
	}

	void loadMainGame() {

		SceneManager.LoadSceneAsync("2.0", LoadSceneMode.Single);
	}
}
