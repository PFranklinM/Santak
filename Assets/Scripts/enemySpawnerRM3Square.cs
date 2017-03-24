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

				GameObject squareEnemyClone = (GameObject)Instantiate (squareEnemy);

				squareEnemyClone.transform.parent = GameObject.Find("spawnerS1").transform;

				Vector3 clonePos = new Vector3 (squareEnemyClone.transform.position.x,
					                  squareEnemyClone.transform.position.y,
					                  squareEnemyClone.transform.position.z);

				clonePos.x = 1495;
				clonePos.y = 140;

				squareEnemyClone.transform.position = clonePos;

				spawnCounter++;
			}

		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM2CheckpointR == true ||
		   GameObject.Find ("Player").GetComponent<playerMove> ().RM4CheckpointL == true) {

			spawnCounter = 0;
		}
	
	}

	void OnEnable() {

		foreach (Transform child in transform) {
			GameObject.Destroy(child.gameObject);
		}

		spawnCounter = 0;
	}
}
