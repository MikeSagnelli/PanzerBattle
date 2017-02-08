//												Author: Michelle Sagnelli
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour {

	private Transform parent; //Get tank body (Player master gameObject per se)
	private Rigidbody rb; //Get rigidbody component

	private float h, j, oldJ; //Inputs

	// Use this for initialization
	void Start () {
		parent = transform.parent; //Get parent transform
		rb = parent.GetComponent<Rigidbody> (); //Get parent rigidbody
		oldJ = 0; //Only one jump at a time
	}

	// Update is called once per frame
	void Update () {
		//Only 2 joysticks will work
		if (this.tag == "Player1") {
			h = Input.GetAxis ("Horizontal1");
			j = Input.GetAxis ("Jump1");

		} else {
			h = Input.GetAxis ("Horizontal2");
			j = Input.GetAxis ("Jump2");
		}

		parent.Translate (0, h * Time.deltaTime * 5, 0);
		//After shooting the tank has a kick back
		if (j == 1 && oldJ == 0) {
			rb.AddForce (-3, -3, 0, ForceMode.Impulse);
		}
		oldJ = j;
	}
}
