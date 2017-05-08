using UnityEngine;
using System.Collections;

public class enemySpawnerBoss3 : MonoBehaviour {

	public GameObject Boss3A;
	public GameObject Boss3B;

	int spawnCounter = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss1CheckpointR == true) {
			if (spawnCounter < 1) {

				GameObject Boss3CloneA = (GameObject)Instantiate (Boss3A);
				GameObject Boss3CloneB = (GameObject)Instantiate (Boss3B);

				Vector3 clonePosA = new Vector3 (Boss3CloneA.transform.position.x,
					Boss3CloneA.transform.position.y,
					Boss3CloneA.transform.position.z);

				Vector3 clonePosB = new Vector3 (Boss3CloneB.transform.position.x,
					Boss3CloneB.transform.position.y,
					Boss3CloneB.transform.position.z);

				clonePosA.x = 7075;
				clonePosA.y = 1258.962f;

				clonePosB.x = 7075;
				clonePosB.y = 1080f;

				Boss3CloneA.transform.position = clonePosA;
				Boss3CloneB.transform.position = clonePosB;

				spawnCounter++;
			}
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().Boss1CheckpointL == true) {

			if (GameObject.Find ("Boss1(Clone)") == null && GameObject.Find ("Boss2(Clone)") == null) {
				spawnCounter = 0;
			}
		}
	
	}
}
