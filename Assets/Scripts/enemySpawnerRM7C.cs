using UnityEngine;
using System.Collections;

public class enemySpawnerRM7C : MonoBehaviour {

	public GameObject circleEnemy;

	int spawnCounter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("SquareWorld") == null) {

			if (GameObject.Find ("Player").GetComponent<playerMove> ().RM7CheckpointL == true ||
				GameObject.Find ("Player").GetComponent<playerMove> ().RM7CheckpointR == true) {

				if (spawnCounter < 1) {

					GameObject circleEnemyClone = (GameObject)Instantiate (circleEnemy);

					circleEnemyClone.transform.parent = GameObject.Find ("enemiesC").transform;

					Vector3 clonePos = new Vector3 (circleEnemyClone.transform.position.x,
						circleEnemyClone.transform.position.y,
						circleEnemyClone.transform.position.z);

					Vector3 spawnerPos = new Vector3 (this.transform.position.x,
						this.transform.position.y,
						this.transform.position.z);

					clonePos.x = spawnerPos.x;
					clonePos.y = spawnerPos.y;

					circleEnemyClone.transform.position = clonePos;
					this.transform.position = spawnerPos;

					spawnCounter++;
				}

			}
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().RM6CheckpointR == true ||
			GameObject.Find ("Player").GetComponent<playerMove> ().RM8CheckpointL == true) {

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
