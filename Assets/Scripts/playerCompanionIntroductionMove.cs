using UnityEngine;
using System.Collections;

public class playerCompanionIntroductionMove : MonoBehaviour {

	public GameObject targetForIntro;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Player").GetComponent<playerMove> ().playerHasMetCompanion == false &&
		   GameObject.Find ("CompanionIntroText").GetComponent<activateCompanionIntroText> ().playerHitTheTrigger == true) {

			transform.position = Vector3.Slerp(this.transform.position, targetForIntro.transform.position, 1 * Time.deltaTime);
		}
	
	}
}
