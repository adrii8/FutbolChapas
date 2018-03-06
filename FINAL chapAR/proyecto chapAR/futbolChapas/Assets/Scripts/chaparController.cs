using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaparController : MonoBehaviour {

	public GameObject chapa;
	public GameObject arrow;
	public GameObject scoreBar;


	public float maxForce;
	public float minForce;
	public Vector3 strikeDirection;

	public Player CurrentPlayer;
	public Player OtherPlayer;

	// Use this for initialization
	void Start () {
		strikeDirection = Vector3.forward;
		CurrentPlayer = new Player("Jugador 1");
		OtherPlayer = new Player("Jugador 2");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
