using UnityEngine;
using System.Collections;

public class bossFinalMove : MonoBehaviour {

	public GameObject player;
	public GameObject bullet;

	bool timeToMove;
	bool moveIntoFrame;

	float moveSpeed;

	float shotTimer;

	public bool canMove;

	// Use this for initialization
	void Start () {

		timeToMove = false;
		moveIntoFrame = false;

		moveSpeed = 85;

		canMove = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 bossMove = new Vector3 (this.transform.position.x,
			this.transform.position.y,
			this.transform.position.z);

		if (GameObject.Find ("Player").GetComponent<triangleWorldPlayerMove> ().cantGoBack == true) {

			moveIntoFrame = true;
		}

		if (moveIntoFrame == true) {
			if (bossMove.y >= 1700) {
				bossMove.y -= moveSpeed * Time.deltaTime;
			}
		}

		this.transform.position = bossMove;

		if (canMove == false) {
			return;
		}

		if (GameObject.Find ("Player").GetComponent<triangleWorldPlayerMove> ().cantGoBack == true) {

			timeToMove = true;
		}

		if (timeToMove == true) {
			
			bossMove.x += moveSpeed * Time.deltaTime;
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

		this.transform.position = bossMove;
	}
}
