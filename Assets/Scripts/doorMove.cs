using UnityEngine;
using System.Collections;

public class doorMove : MonoBehaviour {

	bool doorIsHittable = true;

	Vector3 originalPos;

	public AudioSource theAudio;
	public AudioClip open;
	public AudioClip close;

	// Use this for initialization
	void Start () {

		theAudio = this.GetComponent<AudioSource> ();

		originalPos = new Vector3 (this.transform.position.x,
			this.transform.position.y,
			this.transform.position.z);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "ARbullet") {
			Vector3 doorPos = new Vector3 (transform.position.x,
				transform.position.y,
				transform.position.z);

			if (doorIsHittable == true) {

				theAudio.clip = open;
				theAudio.Play ();

				doorPos.y += 85f;
				doorIsHittable = false;
			}

			transform.position = doorPos;
		}

		if (coll.gameObject.tag == "SGbullet") {
			Vector3 doorPos = new Vector3 (transform.position.x,
				transform.position.y,
				transform.position.z);

			if (doorIsHittable == true) {

				theAudio.clip = open;
				theAudio.Play ();

				doorPos.y += 85f;
				doorIsHittable = false;
			}

			transform.position = doorPos;
		}

		if (coll.gameObject.tag == "explosion") {

			Vector3 doorPos = new Vector3 (transform.position.x,
				transform.position.y,
				transform.position.z);

			if (doorIsHittable == true) {

				theAudio.clip = open;
				theAudio.Play ();

				doorPos.y += 85f;
				doorIsHittable = false;
			}

			transform.position = doorPos;
		}
	}

	public void timeToClose(){
		Vector3 doorPos = new Vector3 (transform.position.x,
			transform.position.y,
			transform.position.z);

		if (transform.position.y > originalPos.y) {

			theAudio.clip = close;
			theAudio.Play ();

			doorPos.y -= 85f;
		}

		doorIsHittable = true;
		transform.position = doorPos;
	}
}
