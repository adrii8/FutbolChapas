using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	private int isJumping;
	private int numMaxSaltos;
	private int counter;
	// Use this for initialization

	void Start () {
		this.counter = 0;
		this.rb = GetComponent<Rigidbody> ();
		this.speed = 25;


	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalAxis = Input.GetAxis("Horizontal");
		float verticalAxis = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(horizontalAxis, 0.0f,verticalAxis);
		rb.AddForce (movement*speed);
		}
			
}

