using UnityEngine;
using System.Collections;

public class enemySpawnerRM3Square : MonoBehaviour {

	public GameObject squareEnemy;

	int spawnCounter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM3CheckpointL == true ||
		   GameObject.Find ("Player").GetComponent<playerMove> ().RM3CheckpointR == true) {

			if (spawnCounter < 1) {

				GameObject jumpingEnemyClone = (GameObject)Instantiate (squareEnemy);

				Vector3 clonePos = new Vector3 (jumpingEnemyClone.transform.position.x,
					                  jumpingEnemyClone.transform.position.y,
					                  jumpingEnemyClone.transform.position.z);

				clonePos.x = 1450;
				clonePos.y = 140;

				jumpingEnemyClone.transform.position = clonePos;

				spawnCounter++;
			}

		}
	
	}
}
