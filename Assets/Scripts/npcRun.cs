using UnityEngine;
using System.Collections;

public class npcRun : MonoBehaviour {

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

		if (timeToRun == true) {
			
			Vector3 direction = this.transform.position - player.transform.position;
			direction.Normalize();

			transform.position = Vector3.MoveTowards(this.transform.position, direction, -10);
		}

		Vector3 NPCPos = new Vector3 (this.transform.position.x,
			                 this.transform.position.y,
			                 this.transform.position.z);

		if (NPCPos.x >= 265 || NPCPos.x <= -265) {
			Destroy (this.gameObject);
		}
	
	}
}
