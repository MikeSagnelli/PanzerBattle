using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	private Rigidbody rb;

	// Use this for initialization
	void Start () {

		//method to retrieve a reference
		rb = GetComponent<Rigidbody> ();

		//if you don't have a component of that type (Rigidbody per se)
		//a null will be returned
		rb.AddRelativeForce (0, 12, 0, ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision c){
		Destroy (gameObject);
	}
}
