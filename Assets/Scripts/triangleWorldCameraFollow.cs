using UnityEngine;
using System.Collections;

public class triangleWorldCameraFollow : MonoBehaviour {

	public GameObject player;

	float offset;

	// Use this for initialization
	void Start () {

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			player.transform.position.y,
			player.transform.position.z);

		Vector3 cameraPos = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		offset = cameraPos.y - playerPos.y;

		transform.position = cameraPos;

		player.transform.position = playerPos;
	
	}
	
	// Update is called once per frame
	void Update () {


		if (GameObject.Find ("Player").GetComponent<triangleWorldPlayerMove> ().cantGoBack == false) {
			Vector3 playerPos = new Vector3 (player.transform.position.x,
				                   player.transform.position.y,
				                   player.transform.position.z);

			Vector3 cameraPos = new Vector3 (transform.position.x,
				                   transform.position.y,
				                   transform.position.z);

			cameraPos.y = playerPos.y + offset;

			transform.position = cameraPos;

			player.transform.position = playerPos;
		}
	
	}
}
