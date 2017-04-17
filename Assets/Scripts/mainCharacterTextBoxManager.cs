using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mainCharacterTextBoxManager : MonoBehaviour {

	public GameObject textBox;
	public Text theText;


	public TextAsset textFile;
	public string [] textLines;

	public int currentLine;
	public int endAtLine;

	public triangleWorldPlayerMove thePlayer;

	public bossFinalMove theBoss;

	public bool isActive;

	float textTimer;

	// Use this for initialization
	void Start () {

		thePlayer = FindObjectOfType<triangleWorldPlayerMove> ();
		theBoss = FindObjectOfType<bossFinalMove> ();

		textTimer = 0.0f;

		if (textFile != null) {
			textLines = (textFile.text.Split ('\n'));
		}

		if (endAtLine == 0) {
			endAtLine = textLines.Length - 1;
		}

		if (isActive == true) {
			enableTextBox ();
		} else {
			disableTextBox ();
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		if (isActive == false) {
			return;
		}

		textTimer += Time.deltaTime;

		theText.text = textLines [currentLine];
	
		if (textTimer >= 2f) {
			currentLine += 1;
			textTimer = 0.0f;
		}

		if (currentLine > endAtLine) {
			disableTextBox ();
		}
	}

	public void enableTextBox(){
		isActive = true;

		textBox.SetActive (true);

		thePlayer.canMove = false;
		theBoss.canMove = false;
	}

	public void disableTextBox(){
		isActive = false;

		textBox.SetActive (false);

		thePlayer.canMove = true;
		theBoss.canMove = true;
	}

	public void reloadScript(TextAsset theText){

		if (theText != null) {
			textLines = new string[1];

			textLines = (theText.text.Split ('\n'));
		}

	}
}
