using UnityEngine;
using System.Collections;

public class enemySpawnerBoss2 : MonoBehaviour {

	public GameObject Boss2;

	int spawnCounter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss2CheckpointR == true) {
			if (spawnCounter < 1) {

				GameObject Boss2Clone = (GameObject)Instantiate (Boss2);

				Vector3 clonePos = new Vector3 (Boss2Clone.transform.position.x,
					Boss2Clone.transform.position.y,
					Boss2Clone.transform.position.z);

				clonePos.x = 7075;
				clonePos.y = 2090f;

				Boss2Clone.transform.position = clonePos;

				spawnCounter++;
			}
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss2CheckpointL == true) {

			if (GameObject.Find ("Boss2(Clone)") == null) {
				spawnCounter = 0;
			}
		}
	
	}
}
