using UnityEngine;
using System.Collections;

public class SGDummyMove : MonoBehaviour {

	float moveSpeed;

	public GameObject target;
	public GameObject Bullet;
	public GameObject player;

	float offset;

	Vector3 newBulletPos;

	// Use this for initialization
	void Start () {

		target = GameObject.Find("Target");
		player = GameObject.Find("Player");

		Vector3 bulletPos = new Vector3 (this.transform.position.x,
			this.transform.position.y,
			this.transform.position.z);

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			                    player.transform.position.y,
			                    player.transform.position.z);

//		if (playerPos.y > bulletPos.y) {
//		offset = -10;
//
//			newBulletPos = new Vector3 (this.transform.position.x,
//				offset,
//				this.transform.position.z);
//		}

//		if (playerPos.y < bulletPos.y) {
		offset = playerPos.y - bulletPos.y;

			newBulletPos = new Vector3 (this.transform.position.x,
			this.transform.position.y + offset,
				this.transform.position.z);
//		}

		moveSpeed = 175f;

		Bullet.GetComponent<Rigidbody2D> ().AddForce ((target.transform.position - newBulletPos).normalized * moveSpeed * Time.fixedDeltaTime);
	}
	
	// Update is called once per frame
	void LateUpdate () {

		if (GameObject.Find ("Target").GetComponent<targetControl> ().AREquipped == true) {

			if (Vector3.Distance (transform.position, player.transform.position) >= 125) {
				Destroy (Bullet);
			}

			if (Vector3.Distance (transform.position, target.transform.position) <= 0.5f) {
				Destroy (Bullet);
			}
		}
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "enemy") {
			Destroy (Bullet);
		}

		if (coll.gameObject.tag == "ground") {
			Destroy (Bullet);
		}

		if (coll.gameObject.tag == "ceiling") {
			Destroy (Bullet);
		}

		if (coll.gameObject.tag == "wall") {
			Destroy (Bullet);
		}

		if (coll.gameObject.tag == "door") {
			Destroy (Bullet);
		}
	}
}
