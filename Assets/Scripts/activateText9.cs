using UnityEngine;
using System.Collections;

public class activateText9 : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public shadowCharacterTextBoxManager textBox;
	public playerWentWhereTheyShouldntBoolScript checkpoint;

	public activateText10 sacrifice;

	bool textHasPlayed = false;


	// Use this for initialization
	void Start () {

		textBox = FindObjectOfType<shadowCharacterTextBoxManager> ();

		checkpoint = FindObjectOfType<playerWentWhereTheyShouldntBoolScript> ();

		sacrifice = FindObjectOfType<activateText10> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "player" && textHasPlayed == false && 
			checkpoint.playerWentWhereTheyShouldnt == true &&
			sacrifice.playerHasDoneTheFirstSacrifice == false) {

			textBox.reloadScript (theText);
			textBox.currentLine = startLine;
			textBox.endAtLine = endLine;
			textBox.enableTextBox ();

			textHasPlayed = true;
		}
	}
}
