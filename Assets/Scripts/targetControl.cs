using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class targetControl : MonoBehaviour {

	public Text Weapon1;
	public Text Weapon2;

	public GameObject weaponText1;
	public GameObject weaponText2;

	public bool playerGotWeaponAdvice;

	public bool playerHasMG;

//	public bool playerCanSwitchWorlds;

	float textSizeTimer;

	float textMoveAmount1;
	float textMoveAmount2;

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
	public bool MLEquipped;

	public bool canShootCuzNotInCutscene;

	public playerMove thePlayer;

	public GameObject squareBackground;
	public GameObject circleBackground;

	//audio
	public AudioSource theAudio;

	public AudioClip MG;
	public AudioClip SG;
	public AudioClip ML;
	public AudioClip selection;
	public AudioClip worldSwitch;

	// Use this for initialization
	void Start () {

		Cursor.visible = false;

		textSizeTimer = 0.0f;

		textMoveAmount1 = 10.0f;
		textMoveAmount2 = 10.0f;

		thePlayer = FindObjectOfType<playerMove> ();

		AREquipped = true;
		MLEquipped = false;

		squareWorld.SetActive (true);
		circleWorld.SetActive (false);

		squareBackground.SetActive (true);
		circleBackground.SetActive (false);

		squareWorldActive = true;

		canShootCuzNotInCutscene = true;

		playerHasMG = true;

//		playerCanSwitchWorlds = true;

		playerGotWeaponAdvice = false;

		weaponText1.SetActive (false);
		weaponText2.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

//		if (thePlayer.canMove == false) {
//			return;
//		}

		if (Input.GetKeyDown (KeyCode.Escape)) {

			SceneManager.LoadScene ("OpeningCinematic", LoadSceneMode.Single);
		}

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			                    player.transform.position.y,
			                    player.transform.position.z);

		pos = Input.mousePosition;

		pos = Camera.main.ScreenToWorldPoint (pos);

		pos.z = -5;

		transform.position = pos;

//Shooting

		if (Input.GetMouseButton (0) && (Time.time > ROF) && AREquipped == true && canShootCuzNotInCutscene == true && playerHasMG == true) {

			shotDelay = 0.1f;

			ROF = Time.time + shotDelay;

			GameObject bulletClone = (GameObject)Instantiate (bullet);

			theAudio.clip = MG;
			theAudio.Play ();

			Physics2D.IgnoreCollision (bulletClone.GetComponent<Collider2D> (), player.GetComponent<Collider2D> ());

			bulletClone.transform.position = player.transform.position;
		}

		if (Input.GetMouseButton (1) && (Time.time > ROF) && AREquipped == true && canShootCuzNotInCutscene == true && playerHasMG == true) {

			shotDelay = 0.75f;

			ROF = Time.time + shotDelay;

			GameObject shellClone1 = (GameObject)Instantiate (shell);
			GameObject shellClone2 = (GameObject)Instantiate (dummyShell);
			GameObject shellClone3 = (GameObject)Instantiate (dummyShell);

			Vector3 shellPos1 = new Vector3 (shellClone1.transform.position.x,
				                    shellClone1.transform.position.y,
				                    shellClone1.transform.position.z);

			Vector3 shellPos2 = new Vector3 (shellClone2.transform.position.x,
				                    shellClone2.transform.position.y,
				                    shellClone2.transform.position.z);

			Vector3 shellPos3 = new Vector3 (shellClone3.transform.position.x,
				                    shellClone3.transform.position.y,
				                    shellClone3.transform.position.z);

			theAudio.clip = SG;
			theAudio.Play ();

			Physics2D.IgnoreCollision (shellClone1.GetComponent<Collider2D> (), player.GetComponent<Collider2D> ());
			Physics2D.IgnoreCollision (shellClone2.GetComponent<Collider2D> (), player.GetComponent<Collider2D> ());
			Physics2D.IgnoreCollision (shellClone3.GetComponent<Collider2D> (), player.GetComponent<Collider2D> ());

			Physics2D.IgnoreCollision (shellClone1.GetComponent<Collider2D> (), shellClone2.GetComponent<Collider2D> ());
			Physics2D.IgnoreCollision (shellClone1.GetComponent<Collider2D> (), shellClone3.GetComponent<Collider2D> ());
			Physics2D.IgnoreCollision (shellClone2.GetComponent<Collider2D> (), shellClone3.GetComponent<Collider2D> ());

			shellPos1.x = playerPos.x;
			shellPos1.y = playerPos.y;

			shellPos2.x = shellPos1.x;
			shellPos2.y = shellPos1.y + Random.Range (9, 11);

			shellPos3.x = shellPos1.x;
			shellPos3.y = shellPos1.y - Random.Range (9, 11);

			shellClone1.transform.position = shellPos1;
			shellClone2.transform.position = shellPos2;
			shellClone3.transform.position = shellPos3;
		}

		if (Input.GetMouseButton (0) && (Time.time > ROF) && MLEquipped == true &&
		    GameObject.Find ("Mine(Clone)") == null && canShootCuzNotInCutscene == true) {

			shotDelay = 0.1f;

			ROF = Time.time + shotDelay;

			GameObject mineClone = (GameObject)Instantiate (mine);

			theAudio.clip = ML;
			theAudio.Play ();

			Physics2D.IgnoreCollision (mineClone.GetComponent<Collider2D> (), player.GetComponent<Collider2D> ());

			mineClone.transform.position = player.transform.position;

		}

		if (Input.GetAxis ("Mouse ScrollWheel") > 0 && canShootCuzNotInCutscene == true && AREquipped == false && playerGotWeaponAdvice == true && playerHasMG == true ||
			Input.GetKeyDown (KeyCode.Alpha1) && canShootCuzNotInCutscene == true && AREquipped == false && playerGotWeaponAdvice == true && playerHasMG == true) {

			AREquipped = true;
			MLEquipped = false;

			if (playerHasMG == true) {
				theAudio.clip = selection;
				theAudio.Play ();
			}
		}

		if (Input.GetAxis ("Mouse ScrollWheel") < 0 && canShootCuzNotInCutscene == true && MLEquipped == false && playerGotWeaponAdvice == true && playerHasMG == true ||
			Input.GetKeyDown (KeyCode.Alpha2) && canShootCuzNotInCutscene == true && MLEquipped == false && playerGotWeaponAdvice == true && playerHasMG == true) {

			AREquipped = false;
			MLEquipped = true;

			if (playerHasMG == true) {
				theAudio.clip = selection;
				theAudio.Play ();
			}
		}

		if (playerGotWeaponAdvice == true) {
			
			weaponText1.SetActive (true);
			weaponText2.SetActive (true);
		}

		if (AREquipped == true && MLEquipped == false && playerHasMG == true) {

			Vector2 textPos1 = new Vector2 (Weapon1.rectTransform.anchoredPosition.x,
				                   Weapon1.rectTransform.anchoredPosition.y);

			Vector2 textPos2 = new Vector2 (Weapon2.rectTransform.anchoredPosition.x,
				                   Weapon2.rectTransform.anchoredPosition.y);

			textPos1.y += textMoveAmount1 * Time.deltaTime;

			textSizeTimer += Time.deltaTime;

			if (textSizeTimer >= 1f) {
				textMoveAmount1 = -textMoveAmount1;
				textSizeTimer = 0.0f;
			}

			textPos2.y = -375;

			Weapon1.fontStyle = FontStyle.Bold;
			Weapon2.fontStyle = FontStyle.Normal;

			Weapon1.color = new Color (1.0f, 1.0f, 0.0f);
			Weapon2.color = new Color (1.0f, 1.0f, 1.0f);

			Weapon1.rectTransform.anchoredPosition = textPos1;
			Weapon2.rectTransform.anchoredPosition = textPos2;
		}

		if (AREquipped == false && MLEquipped == true) {
			
			Vector2 textPos1 = new Vector2 (Weapon1.rectTransform.anchoredPosition.x,
				                   Weapon1.rectTransform.anchoredPosition.y);

			Vector2 textPos2 = new Vector2 (Weapon2.rectTransform.anchoredPosition.x,
				                   Weapon2.rectTransform.anchoredPosition.y);

			textPos2.y += textMoveAmount2 * Time.deltaTime;

			textSizeTimer += Time.deltaTime;

			if (textSizeTimer >= 1f) {
				textMoveAmount2 = -textMoveAmount2;
				textSizeTimer = 0.0f;
			}

			textPos1.y = -375;


			Weapon2.fontStyle = FontStyle.Bold;
			Weapon1.fontStyle = FontStyle.Normal;

			Weapon1.color = new Color (1.0f, 1.0f, 1.0f);
			Weapon2.color = new Color (1.0f, 1.0f, 0.0f);

			Weapon1.rectTransform.anchoredPosition = textPos1;
			Weapon2.rectTransform.anchoredPosition = textPos2;
		}

//World Switching Behavior

//		if (playerCanSwitchWorlds == true) {

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

				theAudio.clip = worldSwitch;
				theAudio.Play ();

				circleWorld.SetActive (true);
				squareWorld.SetActive (false);
				squareBackground.SetActive (false);
				circleBackground.SetActive (true);

				squareWorldActive = false;
			} else if (Input.GetKeyDown (KeyCode.LeftShift) && squareWorldActive == false &&
			          GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false && canShootCuzNotInCutscene == true
			          || Input.GetKeyDown (KeyCode.RightShift) && squareWorldActive == false &&
			          GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false && canShootCuzNotInCutscene == true) {


				theAudio.clip = worldSwitch;
				theAudio.Play ();

				squareWorld.SetActive (true);
				circleWorld.SetActive (false);
				squareBackground.SetActive (true);
				circleBackground.SetActive (false);

				squareWorldActive = true;
			}

			if (GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == true &&
			   squareWorldActive == true && canShootCuzNotInCutscene == true) {

				circleWorld.SetActive (true);

				circleWorldPos.z = -100;
			}

			if (GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == true &&
			   squareWorldActive == false && canShootCuzNotInCutscene == true) {

				squareWorld.SetActive (true);

				squareWorldPos.z = -100;
			}

			if (GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false &&
			   squareWorldActive == true && canShootCuzNotInCutscene == true) {

				circleWorld.SetActive (false);

				circleWorldPos.z = 0;
			}

			if (GameObject.Find ("Player").GetComponent<playerMove> ().screenTransition == false &&
			   squareWorldActive == false && canShootCuzNotInCutscene == true) {

				squareWorld.SetActive (false);

				squareWorldPos.z = 0;
			}

			squareWorld.transform.position = squareWorldPos;
			circleWorld.transform.position = circleWorldPos;

//		}

//		if (playerCanSwitchWorlds == false) {
//			squareWorld.SetActive (false);
//			circleWorld.SetActive (true);
//
//			squareWorldActive = false;
//		}

		player.transform.position = playerPos;

	}
}
