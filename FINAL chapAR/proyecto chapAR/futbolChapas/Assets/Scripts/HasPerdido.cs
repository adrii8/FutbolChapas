using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HasPerdido : MonoBehaviour {

	public AudioClip saw;
	public Text m_MyText;
	private AudioSource audio;
	private bool itHasSound;
	public void LoadScene (int scene){
		SceneManager.LoadScene (scene);
	}


	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = saw;
		audio = GetComponent<AudioSource> ();
		itHasSound = false;

	}


	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "bola") {
			GetComponent<AudioSource> ().Play ();
			m_MyText.text = "Vuelve a intentarlo";
			itHasSound = true;
		}
	}
	void Update (){


		if (!audio.isPlaying && itHasSound)
		{
			LoadScene (0);
		}
	}
}
