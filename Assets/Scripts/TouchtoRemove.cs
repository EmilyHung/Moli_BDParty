using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchtoRemove : MonoBehaviour {

	public GameObject gameobject;
	public GameObject gameobject2;
	public GameObject gameobject3;
	public GameObject gameobject4;
	public GameObject gameobject5;
	//public GameObject gameobject6;

	public bool TouchonButton;

	void Update (){

		if (TouchonButton == true) {

			if (Input.touchCount == 1) {
				Destroy (gameobject);
			}

			if (Input.touchCount == 2) {
				Destroy (gameobject2);
			}

			if (Input.touchCount == 3) {
				Destroy (gameobject3);
			}

			for (var i = 0; i < Input.touchCount; ++i) {
				if (Input.GetTouch (i).phase == TouchPhase.Began) {
					if ((Input.touchCount == 1) && (Input.GetTouch (i).tapCount == 2)) {
						Destroy (gameobject4);
					}

					if ((Input.touchCount == 2) && (Input.GetTouch (i).tapCount == 2)) {
						Destroy (gameobject5);
					}

					//It works, but after some testings, it seems like
					//it's difficult to detect double taps with 3 fingers
					//so I have decided to remove these lines
					//if ((Input.touchCount == 3) && (Input.GetTouch (i).tapCount == 2)) {
						//Destroy (gameobject6);
					//}
				}
			}
				
		} else {
			TouchonButton = false;
		}
			
	}

	public void TouchDown(){
		TouchonButton = true;
		Debug.Log ("Button Pressed");
	}

}
