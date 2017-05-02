using UnityEngine;
using System.Collections;

public class activateCompanionIntroText : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public companionTextBoxManager textBox;

	public bool textHasPlayed = false;

	public bool playerHitTheTrigger;

	// Use this for initialization
	void Start () {

		playerHitTheTrigger = false;

		textBox = FindObjectOfType<companionTextBoxManager> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("CompanionTextBoxManager").GetComponent<companionTextBoxManager> ().isActive == true &&
			playerHitTheTrigger == false) {

			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;
			GameObject.Find ("Player").GetComponent<playerMove> ().canMoveCuzNotInCutscene = false;
		}

		if (GameObject.Find ("CompanionTextBoxManager").GetComponent<companionTextBoxManager> ().isActive == false &&
			playerHitTheTrigger == true) {

			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;
			GameObject.Find ("Player").GetComponent<playerMove> ().canMoveCuzNotInCutscene = true;
		}
	
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "player" && textHasPlayed == false) {

			textBox.reloadScript (theText);
			textBox.currentLine = startLine;
			textBox.endAtLine = endLine;
			textBox.enableTextBox ();

			textHasPlayed = true;

			Invoke ("delay", 1);
		}
	}

	void delay() {
		playerHitTheTrigger = true;
	}
}
