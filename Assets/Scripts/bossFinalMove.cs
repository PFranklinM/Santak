using UnityEngine;
using System.Collections;

public class bossFinalMove : MonoBehaviour {

	public GameObject player;
	public GameObject bullet;

	bool timeToMove;

	float moveSpeed;

	float shotTimer;

	// Use this for initialization
	void Start () {

		timeToMove = false;

		moveSpeed = 5;
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 bossMove = new Vector3 (this.transform.position.x,
			                   this.transform.position.y,
			                   this.transform.position.z);

		if (GameObject.Find ("Player").GetComponent<triangleWorldPlayerMove> ().cantGoBack == true) {

			timeToMove = true;
		}

		if (timeToMove == true) {
			bossMove.x += moveSpeed;

			shotTimer += Time.deltaTime;
		}

		if (bossMove.x >= 130) {
			bossMove.x = 129;
			moveSpeed = -moveSpeed;
		}

		if (bossMove.x <= -130) {
			bossMove.x = -129;
			moveSpeed = -moveSpeed;
		}

		if (shotTimer >= 1.5) {
			shotTimer = 0.0f;

			GameObject bossBulletClone = (GameObject)Instantiate(bullet);

			Physics2D.IgnoreCollision(bossBulletClone.GetComponent<Collider2D>(), this.GetComponent<Collider2D>());

			bossBulletClone.transform.position = this.transform.position;
		}

		Debug.Log (shotTimer);

		this.transform.position = bossMove;
	}
}
