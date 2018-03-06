using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public int speed;
	private Rigidbody rb;
	private int isJumping;
	private int numMaxSaltos;
	private int counter;


	void Start () {
		this.counter = 0;
		this.rb = GetComponent<Rigidbody> ();
		isJumping = 0;
		numMaxSaltos = 2;
	}

	void Update () {
		float horizontalMovement = Input.GetAxis ("Horizontal");
		float verticalMovement = Input.GetAxis ("Vertical");
		Vector3 v = new Vector3 (horizontalMovement * Time.deltaTime * speed , 0.0f, verticalMovement * Time.deltaTime * speed);
		transform.Translate (v);

		if (Input.GetKeyDown ("space") && numMaxSaltos > 0) {
			Vector3 jumpForce = new Vector3 (0.0f, 5.0f, 0.0f);
			rb.AddForce (jumpForce, ForceMode.Impulse);
			numMaxSaltos--;
		}
	}
	void OnCollisionEnter(Collision c){
		this.numMaxSaltos = 2;
	}

	void LateUpdate(){
		
	}
}
