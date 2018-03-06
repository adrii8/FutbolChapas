using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MeshAgentClickController : MonoBehaviour {

	public Camera cam;
	public LayerMask Layer;
	private UnityEngine.AI.NavMeshAgent meshAgent;
	// Use this for initialization
	void Start () {
		meshAgent = GetComponent<NavMeshAgent> (); 
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			Vector3 destination = getPointOnClick ();
			if(destination != new Vector3 (0,0,0)) {
				meshAgent.SetDestination (destination);	
			}
		}
	}


	private Vector3 getPointOnClick(){

		Vector3 pos = Input.mousePosition;
		Vector3 realPos;
	
		Ray ray = cam.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 1000, Layer)) {
			//Debug.Log (hit.transform.gameObject.name);
			Debug.Log (hit.point);
			realPos = hit.point;
		} else {
			Debug.Log ("NO HIT");
			realPos = new Vector3 (0,0,0);
		}

		return realPos;
		 
	}

}
