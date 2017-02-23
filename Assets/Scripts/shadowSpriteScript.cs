using UnityEngine;
using System.Collections;

public class shadowSpriteScript : MonoBehaviour {

	public GameObject player;
	public GameObject playerShadow;


	//shadowSprites
	public Sprite shadowStandingLeft;
	public Sprite shadowStandingRight;

	SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {

		spriteRenderer = GetComponent<SpriteRenderer> ();
		if (spriteRenderer.sprite == null) {
			spriteRenderer.sprite = shadowStandingLeft;
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		if (player.transform.position.x > playerShadow.transform.position.x) {
			spriteRenderer.sprite = shadowStandingRight;
		}

		if (player.transform.position.x < playerShadow.transform.position.x) {
			spriteRenderer.sprite = shadowStandingLeft;
		}
	
	}
}
