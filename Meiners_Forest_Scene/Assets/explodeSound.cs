using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explodeSound : MonoBehaviour {

	public AudioClip explosion;

	void Start ()   
	{
		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = explosion;
	}        

	void OnCollisionEnter ()
	{
		GetComponent<AudioSource> ().Play ();
	}
}
