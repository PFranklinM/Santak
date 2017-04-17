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

	// Use this for initialization
	void Start () {

		moveSpeed = 200;

		health = 4;

		HP1.SetActive (false);
		HP2.SetActive (false);
		HP3.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

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
			if (playerPos.y <= 1499) {
				playerPos.y = 1500;
			}

			if (playerPos.y >= 1766) {
				playerPos.y = 1765;
			}
		}

		transform.position = playerPos;
	
	}
}
