using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttontotextchange : MonoBehaviour {

	public Text mytext = null;
	public Text mytext2 = null;

	public void changeword (string word){
		mytext.text = word;
	}

	public void changeword2 (string word){
		mytext2.text = word;
	}
}
