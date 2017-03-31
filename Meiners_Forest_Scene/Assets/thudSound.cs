using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thudSound : MonoBehaviour  {

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
