using UnityEngine;
using System.Collections;

public class enemySpawnerRM5S : MonoBehaviour {

	public GameObject squareEnemy;

	int spawnCounter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("CircleWorld") == null) {

			if (GameObject.Find ("Player").GetComponent<playerMove> ().RM5CheckpointL == true ||
				GameObject.Find ("Player").GetComponent<playerMove> ().RM5CheckpointR == true) {

				if (spawnCounter < 2) {

					GameObject squareEnemyClone = (GameObject)Instantiate (squareEnemy);

					squareEnemyClone.transform.parent = GameObject.Find ("enemiesS").transform;

					Vector3 clonePos = new Vector3 (squareEnemyClone.transform.position.x,
						squareEnemyClone.transform.position.y,
						squareEnemyClone.transform.position.z);

					clonePos.x = 2810;
					clonePos.y = 201;

					squareEnemyClone.transform.position = clonePos;

					spawnCounter++;
				}

			}
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM4CheckpointR == true ||
			GameObject.Find ("Player").GetComponent<playerMove> ().RM6CheckpointL == true) {

			if (GameObject.Find ("squareEnemy(Clone)") == null) {
				spawnCounter = 0;
			}
		}
	
	}

	//	void OnEnable() {
	//
	//		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM2CheckpointR == true ||
	//		    GameObject.Find ("Player").GetComponent<playerMove> ().RM4CheckpointL == true) {
	//
	//			if (GameObject.Find ("squareEnemy(Clone)") == null) {
	//				spawnCounter = 0;
	//			}
	//		}
	//	}
}
