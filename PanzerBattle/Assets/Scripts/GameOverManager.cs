//												Author: Michelle Sagnelli
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour {

	public TankHP player1, player2; //Retrieve HP for animation trigger

	public float closeDelay = 5f; //Close delay

	Animator anim;
	Animator anim2;

	float closeTimer;

	// Use this for initialization
	void Start () {
		//Retrieve animator
		anim = GetComponent<Animator> ();
		//Retrieve Player1 HP
		player1 = GameObject.Find ("Player1").GetComponent<TankHP>();
		//Retrieve Player 2 HP
		player2 = GameObject.Find ("Player2").GetComponent<TankHP>();
	}

	// Update is called once per frame
	void Update () {
		if (player2.playerHp <= 0) {
			anim.SetTrigger ("Player1");
			closeTimer += Time.deltaTime;
		}
		if (player1.playerHp <= 0) {
			anim.SetTrigger ("Player2");
			closeTimer += Time.deltaTime;
		}

		if (closeTimer >= closeDelay) {
			Application.Quit ();
		}
	}
}
