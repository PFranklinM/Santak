using UnityEngine;
using System.Collections;

public class targetControl : MonoBehaviour {

	public GameObject target;

	public GameObject player;

	public GameObject bullet;

	public GameObject squareWorld;
	public GameObject circleWorld;

	public bool squareWorldActive;

	public Vector2 pos;

	float ROF = 0f;

	float shotDelay = 0f;

	public bool AREquipped;
	public bool SGEquipped;
	public bool HCEquipped;
	public bool RLEquipped;
	public bool MLEquipped;

	public bool playerFacingLeft;
	public bool playerFacingRight;

	public playerMove thePlayer;

	// Use this for initialization
	void Start () {

		thePlayer = FindObjectOfType<playerMove> ();

		AREquipped = true;
		SGEquipped = false;
		HCEquipped = false;
		RLEquipped = false;
		MLEquipped = false;

		playerFacingLeft = false;
		playerFacingRight = true;

		squareWorld.SetActive (true);
		circleWorld.SetActive (false);

		squareWorldActive = true;
	
	}
	
	// Update is called once per frame
	void Update () {

//		if (thePlayer.canMove == false) {
//			return;
//		}

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			player.transform.position.y,
			player.transform.position.z);

		pos = Input.mousePosition;

		pos = Camera.main.ScreenToWorldPoint(pos);

		transform.position = pos;

		if (target.transform.position.x > player.transform.position.x) {
			playerFacingRight = true;
			playerFacingLeft = false;
		}

		if (target.transform.position.x < player.transform.position.x) {
			playerFacingRight = false;
			playerFacingLeft = true;
		}

//Shooting

		if (Input.GetMouseButton(0) && (Time.time > ROF) && AREquipped == true) {

			shotDelay = 0.1f;

			ROF = Time.time + shotDelay;

			GameObject bulletClone = (GameObject)Instantiate(bullet);

			Physics2D.IgnoreCollision(bulletClone.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());

			bulletClone.transform.position = player.transform.position;
		}

//World Switching Behavior

		if (Input.GetMouseButtonDown (1) && squareWorldActive == true) {

			circleWorld.SetActive (true);
			squareWorld.SetActive (false);

			squareWorldActive = false;
		}

		else if (Input.GetMouseButtonDown (1) && squareWorldActive == false) {
			
			squareWorld.SetActive (true);
			circleWorld.SetActive (false);

			squareWorldActive = true;
		}

		player.transform.position = playerPos;

	}
}
