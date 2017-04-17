using UnityEngine;
using System.Collections;

public class NPCRunLeft : MonoBehaviour {

	public GameObject player;

	bool timeToRun;

	// Use this for initialization
	void Start () {

		timeToRun = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (this.transform.position, player.transform.position) < 150f) {

			timeToRun = true;
		}

		Vector3 NPCPos = new Vector3 (this.transform.position.x,
			this.transform.position.y,
			this.transform.position.z);

		if (timeToRun == true) {

			NPCPos.x -= 20;
		}

		if (NPCPos.x >= 265 || NPCPos.x <= -265) {
			Destroy (this.gameObject);
		}

		this.transform.position = NPCPos;
	}
}
