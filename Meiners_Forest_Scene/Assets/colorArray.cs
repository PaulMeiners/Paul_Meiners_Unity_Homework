using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorArray : MonoBehaviour {

	public Material[] myMaterials;
	int arrayPos = 0;

	void updateMaterials ()
	{
		if (Input.GetMouseButtonDown (0)) {
			arrayPos++;
			arrayPos %= myMaterials.Length;
			GetComponent<Renderer> ().material = myMaterials [arrayPos];
		}


	
	}

	void Update ()
	{
		updateMaterials ();
	}
}
