using UnityEngine;
using System.Collections;

public class destroyExplosion : MonoBehaviour {


	private IEnumerator Start(){
		yield return new WaitForSeconds(GetComponent<ParticleSystem>().duration);
		Destroy(this.gameObject); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
