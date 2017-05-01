using UnityEngine;
using System.Collections;

public class playerCompanionIntroductionMove : MonoBehaviour {

	public GameObject targetForIntro;

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Player").GetComponent<playerMove> ().playerHasMetCompanion == false &&
		    GameObject.Find ("CompanionIntroText").GetComponent<activateCompanionIntroText> ().playerHitTheTrigger == true) {

			transform.position = Vector2.MoveTowards (this.transform.position, targetForIntro.transform.position, 100 * Time.deltaTime);

		}

		if (GameObject.Find ("CompanionIntroText").GetComponent<activateCompanionIntroText> ().textHasPlayed == true &&
		          GameObject.Find ("Player").GetComponent<playerMove> ().playerHasMetCompanion == false &&
		          GameObject.Find ("CompanionTextBoxManager").GetComponent<companionTextBoxManager> ().isActive == false) {

			Vector3 playerPos = new Vector3 (player.transform.position.x - 40,
				                    player.transform.position.y,
				                    player.transform.position.z);

			transform.position = Vector2.MoveTowards (this.transform.position, playerPos, 1000 * Time.deltaTime);
		}
	
	}
}
