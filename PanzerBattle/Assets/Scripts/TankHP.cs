//												Author: Michelle Sagnelli
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Used for text in Canvas

public class TankHP : MonoBehaviour {

	public int playerHp = 5; //Counter of Tank's hp

	public Text playerText; //Text for canvas

	// Use this for initialization
	void Start () {
		setPlayerText (); //Calling function
	}

	// Update is called once per frame
	void Update () {
		//Hp is = to 0
		if (playerHp <= 0) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter(Collision c){
		//Got hit
		if (c.gameObject.tag == "Bullet2" || c.gameObject.tag == "Bullet1") {
			playerHp = playerHp - 1;
		}
		//Fell from stage
		if (c.gameObject.tag == "BotDeath") {
			playerHp = 0;
		}
		//Update text in canvas
		setPlayerText ();
	}

	void setPlayerText(){
		//Calling text
		if (this.tag == "Player1") {
			playerText.text = "Player 1 HP: " + playerHp.ToString ();
		} else {
			playerText.text = "Player 2 HP: " + playerHp.ToString ();
		}
	}
}
