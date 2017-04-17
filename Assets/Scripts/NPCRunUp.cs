using UnityEngine;
using System.Collections;

public class NPCRunUp : MonoBehaviour {

	public GameObject player;

	bool timeToRun;

	// Use this for initialization
	void Start () {

		timeToRun = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (this.transform.position, player.transform.position) < 100f) {

			timeToRun = true;
		}

		Vector3 NPCPos = new Vector3 (this.transform.position.x,
			this.transform.position.y,
			this.transform.position.z);

		if (timeToRun == true) {

			NPCPos.y += 175f * Time.deltaTime;
		}

		if (NPCPos.y >= 2150) {
			Destroy (this.gameObject);
		}

		this.transform.position = NPCPos;
	
	}
}
