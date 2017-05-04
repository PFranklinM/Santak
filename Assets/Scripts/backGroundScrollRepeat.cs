using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Sprites;

public class backGroundScrollRepeat : MonoBehaviour {

	public bool isLooping = false;

	private List<SpriteRenderer> backgroundPart;

	// Use this for initialization
	void Start () {

		if (isLooping == true) {
			backgroundPart = new List<SpriteRenderer> ();

			for (int i = 0; i < transform.childCount; i++) {
				
				Transform child = transform.GetChild (i);

				SpriteRenderer r = child.GetComponent<SpriteRenderer> ();

				if (r != null) {
					backgroundPart.Add (r);
				}
			}

			backgroundPart = backgroundPart.OrderBy(
				t => t.transform.position.x
			).ToList();
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		if (isLooping == true) {

			SpriteRenderer firstChild = backgroundPart.FirstOrDefault();

			if (firstChild != null) {

				if (firstChild.transform.position.x < Camera.main.transform.position.x) {



					if (firstChild.IsVisibleFrom(Camera.main) == false) {

						SpriteRenderer lastChild = backgroundPart.LastOrDefault();

						Vector3 lastPosition = lastChild.transform.position;
						Vector3 lastSize = (lastChild.bounds.max - lastChild.bounds.min);

						firstChild.transform.position = new Vector3(lastPosition.x + lastSize.x, firstChild.transform.position.y, firstChild.transform.position.z);

						backgroundPart.Remove(firstChild);
						backgroundPart.Add(firstChild);
					}
				}
			}
		}
	}
}
