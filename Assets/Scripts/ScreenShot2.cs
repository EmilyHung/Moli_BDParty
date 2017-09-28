using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class ScreenShot2 : MonoBehaviour {

	int count = 0;
	public Texture Camera;


	void captureScreenshot(string result){
		if (result == "true") {
			StartCoroutine(CaptureScreen());
		} 
	}

	/*void OnGUI(){
		if (GUI.Button (new Rect (Screen.width /2 + -45, Screen.height /2 + 270, 100, 100), Camera)) {
			captureScreenshot ("true");
		}

		if (GUI.Button (new Rect (Screen.width /2 + -45, Screen.height /2 + 350, 200, 100), "Back")) {
			SceneManager.LoadScene ("Mission3_End");
		}
	}*/
	
	
	public void CamShot(){
		captureScreenshot ("true");
	}

	public void Return(){
		SceneManager.LoadScene ("Mission3_End");
	}

	public IEnumerator CaptureScreen()
	{
		count++;

		// Wait for screen rendering to complete
		yield return new WaitForEndOfFrame();

		Application.CaptureScreenshot ("../../../../DCIM/Camera/screenshot" + count + System.DateTime.Now.ToString(" (yyyy-MM-dd)_(hh-mm-ss)") + ".png");

		//byte[] Bytes_File = System.IO.File.ReadAllBytes("path");

		string Path = System.IO.Path.Combine (Application.persistentDataPath, "screenshot" + count + System.DateTime.Now.ToString(" (yyyy-MM-dd)_(hh-mm-ss)") + ".png");
			Debug.Log ("Path saved is " + Path);

		count = count++;
	}
}