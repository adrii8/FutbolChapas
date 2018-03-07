using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HasPerdido : MonoBehaviour {

	public AudioClip saw;
	public Text m_MyText;
	public void LoadScene (int scene){
		SceneManager.LoadScene (scene);
	}
	//IEnumerator Wait(float duration)


	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = saw;
	}


	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "bola") {
			GetComponent<AudioSource> ().Play ();
			m_MyText.text = "Vuelve a intentarlo";
			//yield return new WaitForSeconds (5);
			LoadScene (0);
				
		}
	}

}
