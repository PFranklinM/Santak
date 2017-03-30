using UnityEngine;
using System.Collections;

public class enemySpawnerBoss1 : MonoBehaviour {

	public GameObject Boss1;

	int spawnCounter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (spawnCounter < 1) {

			GameObject Boss1Clone = (GameObject)Instantiate (Boss1);

			Vector3 clonePos = new Vector3 (Boss1Clone.transform.position.x,
				Boss1Clone.transform.position.y,
				Boss1Clone.transform.position.z);

			clonePos.x = 307;
			clonePos.y = -2939.4f;

			Boss1Clone.transform.position = clonePos;

			spawnCounter++;
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM4CheckpointR == true ||
			GameObject.Find ("Player").GetComponent<playerMove> ().RM6CheckpointL == true) {

			if (GameObject.Find ("Boss(Clone)") == null) {
				spawnCounter = 0;
			}
		}
	
	}
}
