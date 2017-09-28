using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
	public string UserName;
	public InputField InputField;
	public Text text;
	//private TouchScreenKeyboard keyboard;

	void Update()
	{
		UserName = PlayerPrefs.GetString ("playerName", "こどもたち");
		text.text = UserName;
		Debug.Log ("Name Shown!");
	}

	void SetUserName (string text)
	{
		text = InputField.text;
		UserName = text;
		PlayerPrefs.SetString ("playerName", UserName);
		Debug.Log ("Name Saved!");
	}
}

//keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
//if (keyboard != null) {
//SetUserName(keyboard.text);
//}

