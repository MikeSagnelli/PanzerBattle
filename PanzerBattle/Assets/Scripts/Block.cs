using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision c){
		if (c.gameObject.tag == "Bullet1" || c.gameObject.tag == "Bullet2") {
			Destroy (gameObject);
		}
	}
}
