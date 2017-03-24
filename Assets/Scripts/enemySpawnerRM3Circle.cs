using UnityEngine;
using System.Collections;

public class enemySpawnerRM3Circle : MonoBehaviour {

	public GameObject circleEnemy;

	int spawnCounter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM3CheckpointL == true ||
			GameObject.Find ("Player").GetComponent<playerMove> ().RM3CheckpointR == true) {

			if (spawnCounter < 1) {

				GameObject circleEnemyClone = (GameObject)Instantiate (circleEnemy);

				Vector3 clonePos = new Vector3 (circleEnemyClone.transform.position.x,
					circleEnemyClone.transform.position.y,
					circleEnemyClone.transform.position.z);

				clonePos.x = 1495;
				clonePos.y = 140;

				circleEnemyClone.transform.position = clonePos;

				spawnCounter++;
			}

		}
	
	}
}
