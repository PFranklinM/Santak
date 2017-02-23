using UnityEngine;
using System.Collections;

public class activateText6 : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public mainCharacterTextBoxManager MCTextBox;
	public shadowCharacterTextBoxManager SCTextBox;

	bool textHasPlayed = false;

	public bool otherCharacterTalk = false;

	public activateText5 previousText;

	// Use this for initialization
	void Start () {

		MCTextBox = FindObjectOfType<mainCharacterTextBoxManager> ();
		SCTextBox = FindObjectOfType<shadowCharacterTextBoxManager> ();
		previousText = FindObjectOfType<activateText5> ();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (previousText.otherCharacterTalk == true && MCTextBox.isActive == false && textHasPlayed == false) {
			nextPlayerTalking ();
		}
	
	}

	void nextPlayerTalking(){
		SCTextBox.reloadScript (theText);
		SCTextBox.currentLine = startLine;
		SCTextBox.endAtLine = endLine;
		SCTextBox.enableTextBox ();

		textHasPlayed = true;

		otherCharacterTalk = true;
	}
}
