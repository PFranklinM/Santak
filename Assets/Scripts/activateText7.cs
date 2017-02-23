using UnityEngine;
using System.Collections;

public class activateText7 : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public mainCharacterTextBoxManager MCTextBox;
	public shadowCharacterTextBoxManager SCTextBox;

	bool textHasPlayed = false;

	public activateText6 previousText;

	// Use this for initialization
	void Start () {

		MCTextBox = FindObjectOfType<mainCharacterTextBoxManager> ();
		SCTextBox = FindObjectOfType<shadowCharacterTextBoxManager> ();
		previousText = FindObjectOfType<activateText6> ();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (previousText.otherCharacterTalk == true && SCTextBox.isActive == false && textHasPlayed == false) {
			nextPlayerTalking ();
		}
	
	}

	void nextPlayerTalking(){
		MCTextBox.reloadScript (theText);
		MCTextBox.currentLine = startLine;
		MCTextBox.endAtLine = endLine;
		MCTextBox.enableTextBox ();

		textHasPlayed = true;
	}
}
