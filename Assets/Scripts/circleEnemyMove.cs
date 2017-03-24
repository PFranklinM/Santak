using UnityEngine;
using System.Collections;

public class circleEnemyMove : MonoBehaviour {

	public GameObject player;

	public Vector3 startPos;
	public Vector3 endPos;
	public Vector3 dir;

	int health;

	// Use this for initialization
	void Start () {

		player =  GameObject.Find("Player");

		health = 100;
	
	}
	
	// Update is called once per frame
	void Update () {

		//		if (thePlayer.canMove == false) {
		//			return;
		//		}

		Vector3 enemyPos = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		if (Vector3.Distance (this.transform.position, player.transform.position) < 400f) {

			dir.Normalize ();

			Vector3 playerPos = player.transform.position;

			startPos = this.transform.position;
			endPos = playerPos;

			dir = endPos - startPos;

//			enemyPos.z = 0f;

			transform.position += dir * Time.deltaTime * 3f;
		}

		if (health <= 0) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart1").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

		if (GameObject.Find("transitionStart2").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
			Destroy (this.gameObject);
		}

//		if (GameObject.Find("transitionStart3").GetComponent<transitionStartManager> ().playerTouchedTransition == true) {
//			Destroy (this.gameObject);
//		}
	
	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == "ARbullet") {
			health -= 10;
		}
	}

	void OnTriggerEnter2D(Collider2D coll){
		if (coll.gameObject.tag == "transitionEnd") {
			Destroy (this.gameObject);
		}
	}
}
