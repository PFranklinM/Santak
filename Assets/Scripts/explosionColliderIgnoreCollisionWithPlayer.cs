using UnityEngine;
using System.Collections;

public class explosionColliderIgnoreCollisionWithPlayer : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {

		player = GameObject.Find("Player");
	
	}
	
	// Update is called once per frame
	void Update () {

		Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());
	
	}
}
