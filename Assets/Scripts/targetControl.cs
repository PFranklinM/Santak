using UnityEngine;
using System.Collections;

public class targetControl : MonoBehaviour {

	public GameObject target;

	public GameObject player;

	public GameObject bullet;
	public GameObject mine;

	public GameObject squareWorld;
	public GameObject circleWorld;

	public bool squareWorldActive;

	public Vector3 pos;

	float ROF = 0f;

	float shotDelay = 0f;

	public bool AREquipped;
	public bool SGEquipped;
	public bool MLEquipped;

	public playerMove thePlayer;

	// Use this for initialization
	void Start () {

		thePlayer = FindObjectOfType<playerMove> ();

		AREquipped = false;
		SGEquipped = false;
		MLEquipped = true;

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

		pos.z = -5;

		transform.position = pos;

//Shooting

		if (Input.GetMouseButton(0) && (Time.time > ROF) && AREquipped == true) {

			shotDelay = 0.1f;

			ROF = Time.time + shotDelay;

			GameObject bulletClone = (GameObject)Instantiate(bullet);

			Physics2D.IgnoreCollision(bulletClone.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());

			bulletClone.transform.position = player.transform.position;
		}

		if (Input.GetMouseButton (0) && (Time.time > ROF) && MLEquipped == true &&
			GameObject.Find ("Mine(Clone)") == null) {

			shotDelay = 0.1f;

			ROF = Time.time + shotDelay;

			GameObject mineClone = (GameObject)Instantiate(mine);

			Physics2D.IgnoreCollision(mineClone.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());

			mineClone.transform.position = player.transform.position;

		}

//World Switching Behavior

		Vector3 squareWorldPos = new Vector3 (squareWorld.transform.position.x,
			                         squareWorld.transform.position.y,
			                         squareWorld.transform.position.z);

		Vector3 circleWorldPos = new Vector3 (circleWorld.transform.position.x,
			                         circleWorld.transform.position.y,
			                         circleWorld.transform.position.z);

		if (Input.GetMouseButtonDown (1) && squareWorldActive == true &&
			GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false) {

			circleWorld.SetActive (true);
			squareWorld.SetActive (false);

			squareWorldActive = false;
		}

		else if (Input.GetMouseButtonDown (1) && squareWorldActive == false &&
			GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false) {
			
			squareWorld.SetActive (true);
			circleWorld.SetActive (false);

			squareWorldActive = true;
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == true &&
			squareWorldActive == true) {

			circleWorld.SetActive (true);

			circleWorldPos.z = -100;
		}

		if(GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == true &&
			squareWorldActive == false){

			squareWorld.SetActive (true);

			squareWorldPos.z = -100;
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false &&
			squareWorldActive == true) {

			circleWorld.SetActive (false);

			circleWorldPos.z = 0;
		}

		if(GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false &&
			squareWorldActive == false){

			squareWorld.SetActive (false);

			squareWorldPos.z = 0;
		}

		squareWorld.transform.position = squareWorldPos;
		circleWorld.transform.position = circleWorldPos;

		player.transform.position = playerPos;

	}
}
