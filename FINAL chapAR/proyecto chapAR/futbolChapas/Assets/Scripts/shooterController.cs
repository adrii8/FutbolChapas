﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooterController : MonoBehaviour {

	public GameObject shootable;
	private GameObject player;
	private Transform t;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("bola");
		t = shootable.transform;
		StartCoroutine (Fire());
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.LookAt (player.transform.position);
	}

	private IEnumerator Fire(){

		while (true) {
			
			GameObject shoot = (GameObject)Instantiate (shootable, shootable.transform.position, shootable.transform.rotation);
			shoot.SetActive (true);
			shoot.transform.LookAt (player.transform.position);
			Vector3 diffForce = player.transform.position - shoot.transform.position;
			shoot.GetComponent <Rigidbody> ().velocity = diffForce * 2;

			Destroy (shoot, 1);
			yield return new WaitForSeconds (2.0f);
		}
	}
}
