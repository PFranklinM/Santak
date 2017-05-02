using UnityEngine;
using System.Collections;

public class targetControl : MonoBehaviour {

	public GameObject target;

	public GameObject player;

	public GameObject bullet;
	public GameObject shell;
	public GameObject dummyShell;
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

	public bool canShootCuzNotInCutscene;

	public playerMove thePlayer;

	// Use this for initialization
	void Start () {

		thePlayer = FindObjectOfType<playerMove> ();

		AREquipped = true;
		SGEquipped = false;
		MLEquipped = false;

		squareWorld.SetActive (true);
		circleWorld.SetActive (false);

		squareWorldActive = true;

		canShootCuzNotInCutscene = true;
	
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

		if (Input.GetMouseButton (0) && (Time.time > ROF) && AREquipped == true && canShootCuzNotInCutscene == true) {

			shotDelay = 0.1f;

			ROF = Time.time + shotDelay;

			GameObject bulletClone = (GameObject)Instantiate(bullet);

			Physics2D.IgnoreCollision(bulletClone.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());

			bulletClone.transform.position = player.transform.position;
		}

		if (Input.GetMouseButton (1) && (Time.time > ROF) && AREquipped == true && canShootCuzNotInCutscene == true) {

			shotDelay = 1f;

			ROF = Time.time + shotDelay;

			GameObject shellClone1 = (GameObject)Instantiate(shell);
			GameObject shellClone2 = (GameObject)Instantiate(dummyShell);
			GameObject shellClone3 = (GameObject)Instantiate(dummyShell);

			Vector3 shellPos1 = new Vector3 (shellClone1.transform.position.x,
				shellClone1.transform.position.y,
				shellClone1.transform.position.z);

			Vector3 shellPos2 = new Vector3 (shellClone2.transform.position.x,
				shellClone2.transform.position.y,
				shellClone2.transform.position.z);

			Vector3 shellPos3 = new Vector3 (shellClone3.transform.position.x,
				shellClone3.transform.position.y,
				shellClone3.transform.position.z);

			Physics2D.IgnoreCollision(shellClone1.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());
			Physics2D.IgnoreCollision(shellClone2.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());
			Physics2D.IgnoreCollision(shellClone3.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());

			Physics2D.IgnoreCollision(shellClone1.GetComponent<Collider2D>(), shellClone2.GetComponent<Collider2D>());
			Physics2D.IgnoreCollision(shellClone1.GetComponent<Collider2D>(), shellClone3.GetComponent<Collider2D>());
			Physics2D.IgnoreCollision(shellClone2.GetComponent<Collider2D>(), shellClone3.GetComponent<Collider2D>());

			shellPos1.x = playerPos.x;
			shellPos1.y = playerPos.y;

			shellPos2.x = shellPos1.x;
			shellPos2.y = shellPos1.y + Random.Range(9, 11);

			shellPos3.x = shellPos1.x;
			shellPos3.y = shellPos1.y - Random.Range(9, 11);

			shellClone1.transform.position = shellPos1;
			shellClone2.transform.position = shellPos2;
			shellClone3.transform.position = shellPos3;
		}

		if (Input.GetMouseButton (0) && (Time.time > ROF) && MLEquipped == true &&
			GameObject.Find ("Mine(Clone)") == null && canShootCuzNotInCutscene == true) {

			shotDelay = 0.1f;

			ROF = Time.time + shotDelay;

			GameObject mineClone = (GameObject)Instantiate(mine);

			Physics2D.IgnoreCollision(mineClone.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());

			mineClone.transform.position = player.transform.position;

		}

		if(Input.GetKey(KeyCode.Alpha1) && canShootCuzNotInCutscene == true){

			AREquipped = true;
			MLEquipped = false;
		}

		if (Input.GetKey (KeyCode.Alpha3) && canShootCuzNotInCutscene == true) {
			
			AREquipped = false;
			MLEquipped = true;
		}

//World Switching Behavior

		Vector3 squareWorldPos = new Vector3 (squareWorld.transform.position.x,
			                         squareWorld.transform.position.y,
			                         squareWorld.transform.position.z);

		Vector3 circleWorldPos = new Vector3 (circleWorld.transform.position.x,
			                         circleWorld.transform.position.y,
			                         circleWorld.transform.position.z);

		if (Input.GetKeyDown (KeyCode.LeftShift) && squareWorldActive == true &&
			GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false && canShootCuzNotInCutscene == true 
			|| Input.GetKeyDown (KeyCode.RightShift) && squareWorldActive == true &&
			GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false && canShootCuzNotInCutscene == true) {

			circleWorld.SetActive (true);
			squareWorld.SetActive (false);

			squareWorldActive = false;
		}

		else if (Input.GetKeyDown (KeyCode.LeftShift) && squareWorldActive == false &&
			GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false && canShootCuzNotInCutscene == true 
			|| Input.GetKeyDown (KeyCode.RightShift) && squareWorldActive == false &&
			GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false && canShootCuzNotInCutscene == true) {
			
			squareWorld.SetActive (true);
			circleWorld.SetActive (false);

			squareWorldActive = true;
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == true &&
			squareWorldActive == true && canShootCuzNotInCutscene == true) {

			circleWorld.SetActive (true);

			circleWorldPos.z = -100;
		}

		if(GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == true &&
			squareWorldActive == false && canShootCuzNotInCutscene == true){

			squareWorld.SetActive (true);

			squareWorldPos.z = -100;
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false &&
			squareWorldActive == true && canShootCuzNotInCutscene == true) {

			circleWorld.SetActive (false);

			circleWorldPos.z = 0;
		}

		if(GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false &&
			squareWorldActive == false && canShootCuzNotInCutscene == true){

			squareWorld.SetActive (false);

			squareWorldPos.z = 0;
		}

		squareWorld.transform.position = squareWorldPos;
		circleWorld.transform.position = circleWorldPos;

		player.transform.position = playerPos;

	}
}
