using UnityEngine;
using System.Collections;

public class playerCompanionBobUpAndDown : MonoBehaviour {

	float companionMoveTimer;

	float companionMoveAmount;

	// Use this for initialization
	void Start () {

		companionMoveAmount = 10f;
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 companionPos = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		companionPos.y -= companionMoveAmount * Time.deltaTime;
		
		companionMoveTimer += Time.deltaTime;
		
		if(companionMoveTimer >= 1) {
			companionMoveAmount = -companionMoveAmount;
			companionMoveTimer = 0;
		}
	
//		transform.position = companionPos;
	}
}
