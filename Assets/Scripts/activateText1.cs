using UnityEngine;
using System.Collections;

public class activateText1 : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public mainCharacterTextBoxManager textBox;

	bool textHasPlayed = false;

	// Use this for initialization
	void Start () {

		textBox = FindObjectOfType<mainCharacterTextBoxManager> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "player" && textHasPlayed == false) {
			textBox.reloadScript (theText);
			textBox.currentLine = startLine;
			textBox.endAtLine = endLine;
			textBox.enableTextBox ();

			GameObject.Find ("Player").GetComponent<playerMove> ().walkAwayFromHouse = true;

			textHasPlayed = true;
		}
	}

	void OnTriggerExit2D(Collider2D coll){
		textHasPlayed = false;
	}
}
