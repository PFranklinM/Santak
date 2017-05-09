using UnityEngine;
using System.Collections;

public class activateInstructions6 : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public playerTextBoxManager textBox;

	public bool textHasPlayed = false;

	// Use this for initialization
	void Start () {

		textBox = FindObjectOfType<playerTextBoxManager> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Player").GetComponent<playerMove> ().thirdPlaythrough == true) {
			textHasPlayed = false;
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().thirdPlaythrough == false) {
			textHasPlayed = true;
		}
	
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "player" && textHasPlayed == false &&
			GameObject.Find ("Player").GetComponent<playerMove> ().thirdPlaythrough == true) {

			textBox.reloadScript (theText);
			textBox.currentLine = startLine;
			textBox.endAtLine = endLine;
			textBox.enableTextBox ();
		}
	}
}
