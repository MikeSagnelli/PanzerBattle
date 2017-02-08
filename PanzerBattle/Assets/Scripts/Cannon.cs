using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

	//we need something to clone
	public GameObject bullet;

	private Transform child, parent;

	private float oldJ;

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

		float v = Input.GetAxis ("Vertical");
		if (this.tag == "Player1") {
			parent.Rotate (0, 0, v * Time.deltaTime * 20);
		} else {
			parent.Rotate (0, 0, v * Time.deltaTime * -20);
		}

		float j = Input.GetAxis ("Jump");
		if (j == 1 && oldJ == 0) {
			bullet = Instantiate (bullet, child.position, child.rotation);
			if (this.tag == "Player1") {
				bullet.tag = "Bullet1";
			} else {
				bullet.tag = "Bullet2";
			}
		}

		oldJ = j;
	}
}
