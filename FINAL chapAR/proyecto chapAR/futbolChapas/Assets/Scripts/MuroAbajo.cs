using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuroAbajo: MonoBehaviour {
	private Rigidbody rb;
	private float pow = 360.0f;
	private float radius = 30.0f;
	private GameObject gb;
	// Use this for initialization
	void Start () {
		this.rb = GetComponent<Rigidbody>();
		this.gb = GetComponent<GameObject>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision c){
		Vector3 positionOfExplosion = transform.position;
		//c.rigidbody.AddExplosionForce (pow, positionOfExplosion, radius, 360.0f,ForceMode.Impulse);
		c.rigidbody.AddForce (new Vector3(0.0f,0.0f,20.0f),ForceMode.Impulse);
	}
}
