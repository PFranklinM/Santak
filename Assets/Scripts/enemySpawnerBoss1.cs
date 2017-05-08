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


		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss3CheckpointR == true) {
			if (spawnCounter < 1) {

				GameObject Boss1Clone = (GameObject)Instantiate (Boss1);

				Vector3 clonePos = new Vector3 (Boss1Clone.transform.position.x,
					                  Boss1Clone.transform.position.y,
					                  Boss1Clone.transform.position.z);

				clonePos.x = 7075;
				clonePos.y = 3058.504f;

				Boss1Clone.transform.position = clonePos;

				spawnCounter++;
			}
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss3CheckpointL == true) {

			if (GameObject.Find ("Boss1(Clone)") == null) {
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
