using UnityEngine;
using System.Collections;

public class musicManager : MonoBehaviour {

	public AudioSource theAudio;

	public AudioClip music1;
	public AudioClip music2;
	public AudioClip music3;
	public AudioClip music4;

	float audio1Volume = 1.0f;
	float audio2Volume = 0.0f;
	float audio3Volume = 0.0f;
	float audio4Volume = 0.0f;
	bool track1Playing = true;
	bool track2Playing = false;
	bool track3Playing = false;
	bool track4Playing = false;

	// Use this for initialization
	void Start () {

		theAudio.clip = music1;
		theAudio.Play();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("Player").GetComponent<playerMove> ().secondPlaythrough == true) {

			fadeOutSong1 ();

			if (audio1Volume <= 0.1) {
				track1Playing = false;
				if (track2Playing == false) {
					track2Playing = true;
					theAudio.clip = music2;
					theAudio.Play ();
				}

				fadeInSong2 ();
			}
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().thirdPlaythrough == true) {

			fadeOutSong2 ();

			if (audio2Volume <= 0.1) {
				track2Playing = false;
				if (track3Playing == false) {
					track3Playing = true;
					theAudio.clip = music3;
					theAudio.Play ();
				}

				fadeInSong3 ();
			}
		}

		if (GameObject.Find ("Player").GetComponent<playerMove> ().lastPlaythrough == true) {

			fadeOutSong3 ();

			if (audio3Volume <= 0.1) {
				track3Playing = false;
				if (track4Playing == false) {
					track4Playing = true;
					theAudio.clip = music4;
					theAudio.Play ();
				}

				fadeInSong4 ();
			}
		}
	
	}

	void fadeInSong2() {
		if (audio2Volume < 1) {
			audio2Volume += 0.2f * Time.deltaTime;
			theAudio.volume = audio2Volume;
		}
	}

	void fadeOutSong1() {
		if (audio1Volume > 0.1) {
			audio1Volume -= 0.2f * Time.deltaTime;
			theAudio.volume = audio1Volume;
		}
	}

	void fadeInSong1() {
		if (audio1Volume < 1) {
			audio1Volume += 0.2f * Time.deltaTime;
			theAudio.volume = audio1Volume;
		}
	}

	void fadeOutSong2() {
		if (audio2Volume > 0.1) {
			audio2Volume -= 0.2f * Time.deltaTime;
			theAudio.volume = audio2Volume;
		}
	}

	void fadeOutSong3() {
		if (audio3Volume > 0.1) {
			audio3Volume -= 0.2f * Time.deltaTime;
			theAudio.volume = audio3Volume;
		}
	}

	void fadeInSong3() {
		if (audio3Volume < 1) {
			audio3Volume += 0.2f * Time.deltaTime;
			theAudio.volume = audio3Volume;
		}
	}

	void fadeOutSong4() {
		if (audio4Volume > 0.1) {
			audio4Volume -= 0.2f * Time.deltaTime;
			theAudio.volume = audio4Volume;
		}
	}

	void fadeInSong4() {
		if (audio4Volume < 1) {
			audio4Volume += 0.2f * Time.deltaTime;
			theAudio.volume = audio4Volume;
		}
	}
}
