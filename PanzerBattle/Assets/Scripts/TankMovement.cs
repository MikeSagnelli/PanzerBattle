using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

	private Transform parent;

	private float h;

	// Use this for initialization
	void Start () {
		parent = transform.parent;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.tag == "Player1") {
			h = Input.GetAxis ("Horizontal1");
		} else {
			h = Input.GetAxis ("Horizontal2");
		}

		parent.Translate (0, h * Time.deltaTime * 5, 0);
	}
}
