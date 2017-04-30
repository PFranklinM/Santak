using UnityEngine;
using System.Collections;

public class openingCinematicBossMove : MonoBehaviour {

	float moveSpeed;

	public bool timeToMoveRight;

	// Use this for initialization
	void Start () {

		moveSpeed = 85;

		timeToMoveRight = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 bossMove = new Vector3 (transform.position.x,
			                   transform.position.y,
			                   transform.position.z);

		if (bossMove.y <= -90) {
			bossMove.y += moveSpeed * Time.deltaTime;
		}

		if (bossMove.y >= -90) {
			timeToMoveRight = true;
		}

		if (timeToMoveRight == true) {
			bossMove.x += moveSpeed * Time.deltaTime;
		}

		transform.position = bossMove;
	
	}
}
