using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour {

	//we need something to clone
	public GameObject go;

	private Transform parent;

	private float oldJ;

	// Use this for initialization
	void Start () {

		parent = transform.parent;

	}
	
	// Update is called once per frame
	void Update () {

		float h = Input.GetAxis ("Horizontal");
		parent.transform.Translate(0, h * Time.deltaTime, 0);

		float v = Input.GetAxis ("Vertical");
		parent.Rotate (0, 0, v * Time.deltaTime * -20);

		float j = Input.GetAxis ("Jump");

	}
}
