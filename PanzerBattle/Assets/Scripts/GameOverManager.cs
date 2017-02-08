using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour {

	public TankHP player1, player2;

	public float restartDelay = 5f;

	Animator anim;
	Animator anim2;

	float restartTimer;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		player1 = GameObject.Find ("Player1").GetComponent<TankHP>();
		player2 = GameObject.Find ("Player2").GetComponent<TankHP>();
	}
	
	// Update is called once per frame
	void Update () {
		if (player2.playerHp <= 0) {
			anim.SetTrigger ("Player1");
			restartTimer += Time.deltaTime;
		}
		if (player1.playerHp <= 0) {
			anim.SetTrigger ("Player2");
			restartTimer += Time.deltaTime;
		}

		if (restartTimer >= restartDelay) {
			Application.Quit ();
		}
	}
}
