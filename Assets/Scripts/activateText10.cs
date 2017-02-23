using UnityEngine;
using System.Collections;

public class activateText10 : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public shadowCharacterTextBoxManager textBox;

	public playerMove player;

	public targetControl target;

	bool textHasPlayed = false;

	public bool playerHasDoneTheFirstSacrifice = false;

	// Use this for initialization
	void Start () {

		textBox = FindObjectOfType<shadowCharacterTextBoxManager> ();

		player = FindObjectOfType<playerMove> ();

		target = FindObjectOfType<targetControl> ();
	
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

			player.playerHasFlight = false;
			target.AREquipped = true;
			player.playerHasShadow = true;

			playerHasDoneTheFirstSacrifice = true;

			textHasPlayed = true;
		}
	}
}
