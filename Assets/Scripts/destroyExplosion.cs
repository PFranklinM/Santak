using UnityEngine;
using System.Collections;

public class destroyExplosion : MonoBehaviour {

	//audio
	public AudioSource theAudio;
	public AudioClip explosionSound;


	private IEnumerator Start(){

		theAudio.clip = explosionSound;
		theAudio.Play ();

		yield return new WaitForSeconds(GetComponent<ParticleSystem>().duration);
		Destroy(this.gameObject); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
