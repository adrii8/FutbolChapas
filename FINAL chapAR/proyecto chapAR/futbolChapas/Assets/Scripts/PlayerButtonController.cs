﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerButtonController : MonoBehaviour {

	public Text score;
	private int marcador;


	private int speed;
	private Vector3 movement;
	private int active;
	// Use this for initialization
	void Start () {
		movement = transform.position;
		this.speed = 1;
		active = 0;

		this.score.text = "0";
	}


	void Update () {
		//float verticalMovement = Input.GetAxis ("Vertical");
		//if (verticalMovement != 0.0f) {
		if(active == 1){
			transform.Translate (movement *speed* Time.deltaTime);
		}
	}

	public void moveForward(){
		this.movement = transform.forward;
		this.score.text = "me estoy moviendo";
		//transform.Translate (transform.forward * speed * Time.deltaTime);
	}

	public void moveBack(){
		this.movement = -transform.forward;
		//transform.Translate (-transform.forward * speed * Time.deltaTime);
	}


	public void moveLeft(){

		this.movement = -transform.right;
		//transform.Translate (-transform.right * speed * Time.deltaTime);
	}

	public void moveRight(){
		this.movement = transform.right;
		//transform.Translate (transform.right * speed * Time.deltaTime);
	}

	public void ActivateMovement(){
		this.active = 1;
	}

	public void StopMovement(){
		this.active = 0;
	}

	private void PintarScoreYLife(){
		score.text = "Score: " + score.ToString();
	}

}