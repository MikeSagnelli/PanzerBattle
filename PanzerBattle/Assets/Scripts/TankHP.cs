using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHP : MonoBehaviour {

	public int playerHp = 5;

	public Text playerText;

	// Use this for initialization
	void Start () {
		setPlayerText ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHp <= 0) {
			Destroy (gameObject);
		}
	}
	void OnCollisionEnter(Collision c){
		if (c.gameObject.tag == "Bullet2" || c.gameObject.tag == "Bullet1") {
			playerHp = playerHp - 1;
		}
		if (c.gameObject.tag == "BotDeath") {
			playerHp = 0;
		}
		setPlayerText ();
	}

	void setPlayerText(){
		if (this.tag == "Player1") {
			playerText.text = "Player 1 HP: " + playerHp.ToString ();
		} else {
			playerText.text = "Player 2 HP: " + playerHp.ToString ();
		}
	}
}
