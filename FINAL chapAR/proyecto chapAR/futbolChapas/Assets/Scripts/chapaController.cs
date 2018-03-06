using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chapaController : MonoBehaviour {

	public GameObject chapa1;
	public Vector3 strikeDirection;
	public Rigidbody rb;
	public float KickSpeed = 1000000f;
	public float forwardSpeed = 1000000f;

	public const float MIN_DISTANCE = 27.5f;
	public const float MAX_DISTANCE = 32f;
	// Use this for initialization
	void Start () {
		strikeDirection = Vector3.forward;
		GetComponent<Rigidbody>().sleepThreshold = 0.15f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("up"))
			rb.AddForce ( 0, 0, KickSpeed * Time.deltaTime);
		if (Input.GetKeyDown ("down"))
			rb.AddForce ( 0, 0, -KickSpeed * Time.deltaTime);
		if (Input.GetKeyDown (KeyCode.Space))
			rb.AddForce (forwardSpeed * Time.deltaTime, 0, 0);
		if (Input.GetKeyDown ("right"))
			rb.AddForce (forwardSpeed*Time.deltaTime, 0, 0);
		if (Input.GetKeyDown ("left"))
			rb.AddForce (-forwardSpeed*Time.deltaTime, 0, 0);
	}
}
