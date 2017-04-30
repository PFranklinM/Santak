using UnityEngine;
using System.Collections;

public class lightFollow : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	// Use this for initialization
	void Start () {

		offset = transform.position - player.transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate () {

		transform.position = player.transform.position + offset;
	}
}
