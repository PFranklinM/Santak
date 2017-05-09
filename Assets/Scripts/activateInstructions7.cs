using UnityEngine;
using System.Collections;

public class activateInstructions7 : MonoBehaviour {

	public TextAsset theText;

	public int startLine;
	public int endLine;

	public playerTextBoxManager textBox;

	public bool textHasPlayed = false;

	public GameObject X;

	// Use this for initialization
	void Start () {

		textBox = FindObjectOfType<playerTextBoxManager> ();

		X.SetActive (false);
	
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

			X.SetActive (true);

			GameObject.Find ("Target").GetComponent<targetControl> ().AREquipped = false;
			GameObject.Find ("Target").GetComponent<targetControl> ().MLEquipped = true;

			textHasPlayed = true;
		}
	}
}
