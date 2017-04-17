using UnityEngine;
using System.Collections;

public class triangleWorldPlayerMove : MonoBehaviour {

	public GameObject player;

	float moveSpeed;

	public int health;

	public GameObject HP1;
	public GameObject HP2;
	public GameObject HP3;

	public bool cantGoBack;

	bool playerWasHitByBullet;

	public bool canMove;

	// Use this for initialization
	void Start () {

		cantGoBack = false;
		playerWasHitByBullet = false;

		moveSpeed = 200;

		health = 4;

		HP1.SetActive (false);
		HP2.SetActive (false);
		HP3.SetActive (false);

		canMove = true;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (canMove == false) {
			return;
		}

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			player.transform.position.y,
			player.transform.position.z);

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


		if (Input.GetKey (KeyCode.A)) {
			playerPos.x -= moveSpeed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.D)) {
			playerPos.x += moveSpeed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.W)) {
			playerPos.y += moveSpeed * Time.deltaTime;
		}

		if (Input.GetKey (KeyCode.S)) {
			playerPos.y -= moveSpeed * Time.deltaTime;
		}

		if (playerPos.x <= -220) {
			playerPos.x = -220;
		}

		if (playerPos.x >= 220) {
			playerPos.x = 220;
		}

		if (playerPos.y <= -131) {
			playerPos.y = -131;
		}

		if (playerPos.y >= 1500) {
			cantGoBack = true;
		}

		if (cantGoBack == true) {
			if (playerPos.y <= 1500) {
				playerPos.y = 1500;
			}

			if (playerPos.y >= 1765) {
				playerPos.y = 1765;
			}
		}

		if (playerWasHitByBullet == true) {
			
			playerPos.y -= 700 * Time.deltaTime;
		}

		if (playerPos.x <= -210 || playerPos.x >= 210 || playerPos.y <= 1510 || playerPos.y >= 1755) {

			playerWasHitByBullet = false;
		}

		transform.position = playerPos;
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "enemyBullet") {

			playerWasHitByBullet = true;

			health -= 1;
		}
	}
}
