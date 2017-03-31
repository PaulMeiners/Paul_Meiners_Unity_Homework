using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dingSound : MonoBehaviour {

	public AudioClip bigThud;

	void Start ()   
	{
		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = bigThud;
	}        

	void OnCollisionEnter ()
	{
		GetComponent<AudioSource> ().Play ();
	}
}
