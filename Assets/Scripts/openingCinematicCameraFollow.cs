using UnityEngine;
using System.Collections;

public class openingCinematicCameraFollow : MonoBehaviour {

	public GameObject boss;

	float offset;

	// Use this for initialization
	void Start () {

		Vector3 bossPos = new Vector3 (boss.transform.position.x,
			boss.transform.position.y,
			boss.transform.position.z);

		Vector3 cameraPos = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		offset = cameraPos.x - bossPos.x;

		transform.position = cameraPos;

		boss.transform.position = bossPos;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate () {

		if (GameObject.Find ("FinalBoss").GetComponent<openingCinematicBossMove> ().timeToMoveRight == true) {

			Vector3 bossPos = new Vector3 (boss.transform.position.x,
				boss.transform.position.y,
				boss.transform.position.z);

			Vector3 cameraPos = new Vector3 (transform.position.x,
				transform.position.y,
				transform.position.z);

			cameraPos.x = bossPos.x + offset;

			transform.position = cameraPos;

			boss.transform.position = bossPos;
		}

	}
}
