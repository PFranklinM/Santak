using UnityEngine;
using System.Collections;

public class mainMenuTargetControl : MonoBehaviour {

	public Vector3 pos;

	// Use this for initialization
	void Start () {

		Cursor.visible = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		pos = Input.mousePosition;

		pos = Camera.main.ScreenToWorldPoint (pos);

		pos.z = -10;

		transform.position = pos;
	
	}
}
