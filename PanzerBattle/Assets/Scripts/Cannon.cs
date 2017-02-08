//												Author: Michelle Sagnelli
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

	//we need something to clone
	public GameObject bPreFav, //Used to keep cloning bullet gameObject
	 									bullet;

	private Transform child, //Bullets origin
	 									parent; //Tank head rotation

	private float oldJ, v, j; //Inputs

	//use this for initialization
	void Start () {
		//cannon rotation
		parent = transform.parent;
		//bullet spawn
		child = transform.GetChild (0);
		//only a bullet for each press
		oldJ = 0;
	}

	//update is called once per frame
	void Update () {

		//Only 2 joysticks will work
		if (this.tag == "Player1") {
			v = Input.GetAxis ("Vertical1");

			parent.Rotate (0, 0, v * Time.deltaTime * 20);

			j = Input.GetAxis ("Jump1");

			if (j == 1 && oldJ == 0) {
				bullet = Instantiate (bPreFav, child.position, child.rotation);
				bullet.tag = "Bullet1";
			}
		} else {
			v = Input.GetAxis ("Vertical2");

			parent.Rotate (0, 0, v * Time.deltaTime * -20);

			j = Input.GetAxis ("Jump2");

			if (j == 1 && oldJ == 0) {
				bullet = Instantiate (bPreFav, child.position, child.rotation);
				bullet.tag = "Bullet2";
			}
		}

		oldJ = j;
	}
}
