using UnityEngine;
using System.Collections;

public class keyBehavior : MonoBehaviour {

	Vector3 originalPos;

	public GameObject player;

	// Use this for initialization
	void Start () {

		originalPos = new Vector3 (this.transform.position.x,
			this.transform.position.y,
			this.transform.position.z);
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 keyPos = new Vector3 (transform.position.x,
			                 transform.position.y,
			                 transform.position.z);

		Vector3 playerPos = new Vector3 (player.transform.position.x,
			                    player.transform.position.y,
			                    player.transform.position.z);


		if (GameObject.Find ("Player").GetComponent<playerMove> ().playerHasKey == true) {

			keyPos.x = playerPos.x;
			keyPos.y = playerPos.y + 7.5f;

			this.transform.position = keyPos;
			player.transform.position = playerPos;

			Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().playerHasKey == false) {
			this.transform.position = originalPos;

			Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), player.GetComponent<Collider2D>(), false);
		}
	}
}
