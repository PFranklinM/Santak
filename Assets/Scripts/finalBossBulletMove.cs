using UnityEngine;
using System.Collections;

public class finalBossBulletMove : MonoBehaviour {

	public GameObject player;

	Quaternion lookRotation;
	Vector3 direction;

	float moveSpeed;

	// Use this for initialization
	void Start () {

		player = GameObject.Find("Player");

		moveSpeed = 1500000f;

		Vector3 targetDir = player.transform.position - this.transform.position;

		Quaternion bossBulletRotation = Quaternion.LookRotation(targetDir);

		bossBulletRotation.x = 0.0f;
		bossBulletRotation.y = 0.0f;

		this.transform.rotation = bossBulletRotation;

		this.GetComponent<Rigidbody2D> ().AddForce ((player.transform.position - this.transform.position).normalized * moveSpeed * Time.fixedDeltaTime);
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 bulletPos = new Vector3 (this.transform.position.x,
			                    this.transform.position.y,
			                    this.transform.position.z);

		if (bulletPos.y <= 1390) {
			Destroy (this.gameObject);
		}

		this.transform.position = bulletPos;
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "player") {

			Destroy (this.gameObject);
		}
	}
}
