using UnityEngine;
using System.Collections;

public class buttonMoveRM8 : MonoBehaviour {

	Vector3 originalPos;

	float buttonDownTimer;

	float buttonUpTimer;

	bool somethingOnButton;

	bool buttonActive;

	public bool boxOnButton;

	public GameObject hiddenStaircase1;

	// Use this for initialization
	void Start () {

		originalPos = new Vector3 (this.transform.position.x,
			this.transform.position.y,
			this.transform.position.z);

		buttonDownTimer = 0.0f;
		buttonUpTimer = 0.0f;

		somethingOnButton = false;

		buttonActive = true;

		boxOnButton = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (somethingOnButton == false) {

			buttonUpTimer += Time.deltaTime;

			Vector3 buttonPos = new Vector3 (transform.position.x,
				transform.position.y,
				transform.position.z);

			if (transform.position.y < originalPos.y && buttonUpTimer >= 0.2f) {
				buttonPos.y += 1f;

				buttonDownTimer = 0.0f;

				buttonActive = true;
			}

			transform.position = buttonPos;
		}

		if (buttonActive == false) {
			hiddenStaircase1.SetActive (true);
		} else {
			hiddenStaircase1.SetActive (false);
		}
	
	}

	void OnCollisionEnter2D(Collision2D coll){

		somethingOnButton = true;

		buttonUpTimer = 0.0f;

		buttonDownTimer += Time.deltaTime;

		Vector3 buttonPos = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		if (buttonDownTimer <= 0.1f) {

			buttonPos.y -= 1f;

			transform.position = buttonPos;
		}

		buttonActive = false;

		if (coll.gameObject.tag == "ground") {
			boxOnButton = true;
		}
	}

	void OnCollisionExit2D(Collision2D coll){

		if (coll.gameObject.tag == "ground") {
			boxOnButton = false;
		}

		if (boxOnButton == false) {
			somethingOnButton = false;
		}
	}
}
