﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerTextBoxManager : MonoBehaviour {

	public GameObject textBox;
	public Text theText;


	public TextAsset textFile;
	public string [] textLines;

	public int currentLine;
	public int endAtLine;

	public bool isActive;

	// Use this for initialization
	void Start () {

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

		theText.text = textLines [currentLine];

		if (Input.GetKeyDown(KeyCode.Return)) {
			currentLine += 1;
		}

		if (currentLine > endAtLine) {
			disableTextBox ();
		}
	
	}

	public void enableTextBox() {
		isActive = true;

		textBox.SetActive (true);
	}

	public void disableTextBox() {
		isActive = false;

		textBox.SetActive (false);
	}

	public void reloadScript(TextAsset theText){

		if (theText != null) {
			textLines = new string[1];

			textLines = (theText.text.Split ('\n'));
		}

	}
}
