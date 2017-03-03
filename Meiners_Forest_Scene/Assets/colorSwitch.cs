using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorSwitch : MonoBehaviour {

	private Renderer ren;
	private bool state = true;

	public Material on;
	public Material off;

	// Use this for initialization
	void Start () {
		ren = this.GetComponent<Renderer> ();
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "playerSphere") {
			print ("Contact");
			state = !state;
			if (state) {
				ren.material = on;
			} else {
				ren.material = off;
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
