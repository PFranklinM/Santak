using UnityEngine;
using System.Collections;

public class activateFinalBossText : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public bossTextBoxManagerEnding textBox;

	bool textHasPlayed = false;

	// Use this for initialization
	void Start () {

		textBox = FindObjectOfType<bossTextBoxManagerEnding> ();
	
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

			textHasPlayed = true;
		}
	}
}
