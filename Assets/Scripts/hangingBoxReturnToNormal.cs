using UnityEngine;
using System.Collections;

public class hangingBoxReturnToNormal : MonoBehaviour {

	Vector3 originalPos;

	// Use this for initialization
	void Start () {

		originalPos = new Vector3 (this.transform.position.x,
			this.transform.position.y,
			this.transform.position.z);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find("transitionStart1").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			
			this.transform.position = originalPos;
			this.GetComponent<HingeJoint2D>().enabled = true;
			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
		}

		if (GameObject.Find("transitionStart2").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			
			this.transform.position = originalPos;
			this.GetComponent<HingeJoint2D>().enabled = true;
			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
		}

		if (GameObject.Find("transitionStart3").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {

			this.transform.position = originalPos;
			this.GetComponent<HingeJoint2D>().enabled = true;
			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
		}

		if (GameObject.Find("transitionStart4").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {

			this.transform.position = originalPos;
			this.GetComponent<HingeJoint2D>().enabled = true;
			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
		}

		if (GameObject.Find("transitionStart5").GetComponent<lockedTransitionStartManager> ().playerTouchedTransition == true) {

			this.transform.position = originalPos;
			this.GetComponent<HingeJoint2D>().enabled = true;
			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
		}

		if (GameObject.Find("transitionStart6").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {

			this.transform.position = originalPos;
			this.GetComponent<HingeJoint2D>().enabled = true;
			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
		}

		if (GameObject.Find("transitionStart7").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {

			this.transform.position = originalPos;
			this.GetComponent<HingeJoint2D>().enabled = true;
			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
		}

		if (GameObject.Find("transitionStart8").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {

			this.transform.position = originalPos;
			this.GetComponent<HingeJoint2D>().enabled = true;
			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
		}

		if (GameObject.Find("transitionStart9").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {

			this.transform.position = originalPos;
			this.GetComponent<HingeJoint2D>().enabled = true;
			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
		}

		if (GameObject.Find("transitionStart10").GetComponent<lockedTransitionStartManager> ().playerTouchedTransition == true) {

			this.transform.position = originalPos;
			this.GetComponent<HingeJoint2D>().enabled = true;
			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
		}

//		if (GameObject.Find("transitionStart11").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//
//			this.transform.position = originalPos;
//			this.GetComponent<HingeJoint2D>().enabled = true;
//			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
//			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
//		}
//
//		if (GameObject.Find("transitionStart12").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//
//			this.transform.position = originalPos;
//			this.GetComponent<HingeJoint2D>().enabled = true;
//			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
//			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
//		}
//
//		if (GameObject.Find("transitionStart13").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//
//			this.transform.position = originalPos;
//			this.GetComponent<HingeJoint2D>().enabled = true;
//			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
//			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
//		}
//
//		if (GameObject.Find("transitionStart14").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//
//			this.transform.position = originalPos;
//			this.GetComponent<HingeJoint2D>().enabled = true;
//			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
//			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
//		}
//
//		if (GameObject.Find("transitionStart15").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//
//			this.transform.position = originalPos;
//			this.GetComponent<HingeJoint2D>().enabled = true;
//			GameObject.Find ("button1").GetComponent<buttonMoveRM4> ().boxOnButton = false;
//			GameObject.Find ("button2").GetComponent<buttonMoveRM8> ().boxOnButton = false;
//		}
	
	}
}
