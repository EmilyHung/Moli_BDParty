using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChange2: MonoBehaviour {

	public Image image;

	public void DestroyGameObject()
	{
		Destroy(image);
	}
}
