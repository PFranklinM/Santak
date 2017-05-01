using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerFadeIn : MonoBehaviour {

	Material mat;
	Color colorA;

	Rigidbody2D rb;

	public bool freezeOnlyOnce;

	// Use this for initialization
	void Start () {

		Color color = this.gameObject.GetComponent<Renderer>().material.color; 
		Color newColor = new Color(color.r, color.g, color.b, 0.0f); 
		this.gameObject.GetComponent<Renderer>().material.color = newColor;

		rb = GetComponent<Rigidbody2D>();

		rb.gravityScale = 0;
		GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = false;
		GameObject.Find ("Player").GetComponent<playerMove> ().canMoveCuzNotInCutscene = false;

		freezeOnlyOnce = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (freezeOnlyOnce == true) {
			return;
		}

		mat = GetComponent<Renderer> ().material;

		colorA = mat.color;
		colorA.a += 0.75f * Time.deltaTime;

//		mat.SetColor ("_EmissionColor", colorA);
		mat.SetColor ("_Color", colorA);
//		mat.SetColor ("_TintColor", colorA);

		if (colorA.a >= 0.99999 && freezeOnlyOnce == false) {

			Color color = this.gameObject.GetComponent<Renderer>().material.color; 
			Color newColor = new Color(color.r, color.g, color.b, 1.0f); 
			this.gameObject.GetComponent<Renderer>().material.color = newColor;

			rb.gravityScale = 175;
			GameObject.Find ("Target").GetComponent<targetControl> ().canShootCuzNotInCutscene = true;
			GameObject.Find ("Player").GetComponent<playerMove> ().canMoveCuzNotInCutscene = true;

			freezeOnlyOnce = true;
		}
	
	}
}
