using UnityEngine;
using System.Collections;

public class enemySpawnerRM5C : MonoBehaviour {

	public GameObject circleEnemy;

	int spawnCounter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("SquareWorld") == null) {

			if (GameObject.Find ("Player").GetComponent<playerMove> ().RM5CheckpointL == true ||
			    GameObject.Find ("Player").GetComponent<playerMove> ().RM5CheckpointR == true) {

				if (spawnCounter < 2) {

					GameObject circleEnemyClone = (GameObject)Instantiate (circleEnemy);

					circleEnemyClone.transform.parent = GameObject.Find ("enemiesC").transform;

					Vector3 clonePos = new Vector3 (circleEnemyClone.transform.position.x,
						                   circleEnemyClone.transform.position.y,
						                   circleEnemyClone.transform.position.z);

					clonePos.x = 2810 + Random.Range (-50, 50);
					clonePos.y = 201;

					circleEnemyClone.transform.position = clonePos;

					spawnCounter++;
				}

			}
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM4CheckpointR == true ||
		    GameObject.Find ("Player").GetComponent<playerMove> ().RM6CheckpointL == true) {

			if (GameObject.Find ("circleEnemy(Clone)") == null) {
				spawnCounter = 0;
			}
		}
	
	}

	//	void OnEnable() {
	//		
	//		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM2CheckpointR == true ||
	//			GameObject.Find ("Player").GetComponent<playerMove> ().RM4CheckpointL == true) {
	//
	//			if (GameObject.Find ("circleEnemy(Clone)") == null) {
	//				spawnCounter = 0;
	//			}
	//		}
	//	}
}
