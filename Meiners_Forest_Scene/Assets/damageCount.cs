using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageCount : MonoBehaviour {

	public float parameter1 = 100;
	public float parameter2 = 10;

	// Use this for initialization
	void Start () {
	}

	void OnCollisionEnter(Collision collision)
	{
		{
			parameter1 = parameter1 - parameter2;
			print(parameter1);
		}

		if(parameter1 < 0)
		{
			Destroy(gameObject);
		}
	}
}