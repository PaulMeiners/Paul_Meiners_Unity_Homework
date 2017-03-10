using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopTest : MonoBehaviour {

		int time = 10;


		void Start ()
		{
			for(int i = 0; i < time; i++)
			{
				Debug.Log("time: " + i);
			}
		}
	}
