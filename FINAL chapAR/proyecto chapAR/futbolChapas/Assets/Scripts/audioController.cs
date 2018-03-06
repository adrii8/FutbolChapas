using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioController : MonoBehaviour {

	public AudioClip saw;
	public Text m_MyText;


	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = saw;
	}


	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "bola") {
			GetComponent<AudioSource> ().Play ();
			m_MyText.text = "Has ganado!!";

		}

	}
	// Update is called once per frame
	void Update () {
		
	}
}
