using UnityEngine;
using System.Collections;

public class playerCompanionMove : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 companionPos = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			                    player.transform.position.y,
			                    player.transform.position.z);

		if(companionPos.x <= 107.5f && companionPos.y - playerPos.y <= 2 &&
			GameObject.Find ("Player").GetComponent<playerMove> ().playerHasMetCompanion == false){

			companionPos.x = -108.4f;
			companionPos.y = playerPos.y;

			GameObject.Find ("Player").GetComponent<playerMove> ().playerHasMetCompanion = true;
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().playerHasMetCompanion == true) {
			if (GameObject.Find ("Player").GetComponent<playerMove> ().facingLeft == true) {
				companionPos.x = playerPos.x + 40f;
			}

			if (GameObject.Find ("Player").GetComponent<playerMove> ().facingRight == true) {
				companionPos.x = playerPos.x - 40f;
			}

			companionPos.y = playerPos.y + 0.5f;
		}

		transform.position = companionPos;
	
	}
}
