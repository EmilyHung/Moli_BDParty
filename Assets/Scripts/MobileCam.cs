using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class MobileCam : MonoBehaviour {

	private bool camAvailable; //bool: True/False value
	private WebCamTexture frontCam;
	private Texture defaultBackground;

	public RawImage background;
	public AspectRatioFitter fit;

	// Use this for initialization
	void Start () {
		defaultBackground = background.texture;
		WebCamDevice[] devices = WebCamTexture.devices;

		//Case 1: No camera detected
		if (devices.Length == 0) 
		{
			Debug.Log ("No camera detected!");
			camAvailable = false;
			return;
		}

		//Case 2: front camera is detected
		//This time I only need front camera
		for (int i = 0; i < devices.Length; i++)
		{
			if (devices [i].isFrontFacing) 
			{
				frontCam = new WebCamTexture (devices [i].name, Screen.width, Screen.height);
			}
		}	


		//Case 3: Front camera is detected
		if (frontCam == null) 
		{
			Debug.Log ("Unable to find back camera");
			return;
		}

		frontCam.Play ();
		background.texture = frontCam;

		camAvailable = true; //Set the camAvailable for future purposes
	}

	// Update is called once per frame
	void Update () {
		if (!camAvailable)
		{
			return;
		}

		//Setup aspect ratio for device
		float ratio = (float)frontCam.width / (float)frontCam.height;
		fit.aspectRatio = ratio;

		//See if the camera image is mirrored or not
		float scaleY = frontCam.videoVerticallyMirrored ? -1f : 1f;
		background.rectTransform.localScale = new Vector3(1f, -scaleY, 1f); // Swap if it's mirrored

		//Setup for vertical / horizontal Rotation
		int orient = -frontCam.videoRotationAngle;
		background.rectTransform.localEulerAngles = new Vector3(0,0, orient);
	}

}
