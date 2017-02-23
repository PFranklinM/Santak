using UnityEngine;
using System.Collections;

public class activateText2 : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public shadowCharacterTextBoxManager textBox;

	public GameObject lockedInWall;

	bool textHasPlayed = false;

	public bool otherCharacterTalk = false;

	// Use this for initialization
	void Start () {

		textBox = FindObjectOfType<shadowCharacterTextBoxManager> ();

		lockedInWall.SetActive (false);
	
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

			otherCharacterTalk = true;

			textHasPlayed = true;

			lockedInWall.SetActive (true);
		}
	}
}
