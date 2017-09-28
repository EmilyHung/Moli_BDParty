using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChange : MonoBehaviour {

	public Image image;
	public int clickcounter = 0;

	public void ClickToChange1(){
		clickcounter++;
		if (clickcounter % 2 == 1) {
			image.sprite = Resources.Load<Sprite> ("01_dancexxxhdpi");
		} else {
			image.sprite = Resources.Load<Sprite> ("01_normalxxxhdpi");
		}
	}
}