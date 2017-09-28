using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroy : MonoBehaviour {

	void Awake () {
		GameObject[] objs = GameObject.FindGameObjectsWithTag ("music");

		if (objs.Length > 1) {
			Destroy (this.gameObject);
		}
			
		DontDestroyOnLoad (this.gameObject);

	}
}


