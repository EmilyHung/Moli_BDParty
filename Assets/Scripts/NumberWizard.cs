using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {
	//Declare variables
	int max;
	int min;
	int guess;

	public Text text;
	public Text text2;

	int maxGuessAllowed = 6;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame(){
		//initialize variables
		//beware! no need add "int"
		//otherwise it redeclares the variables again
		max = 100;
		min = 1;
		guess = 50;

		//because unity will round-down numbers
		//Without this line of code, the max number to be guessed
		//will only reach to 99
		max = max + 1;
	}

	public void GuessLower(){
		max = guess;
		NextGuess();
	}

	public void GuessHigher(){
		min = guess;
		NextGuess();
	}

	void NextGuess(){
		guess = (max + min) / 2;
		text.text = guess.ToString();
		maxGuessAllowed = maxGuessAllowed - 1;
		if (maxGuessAllowed < 0) {
			SceneManager.LoadScene ("Mission1_Lose");
		}
		Reminder ();
	}

	void Reminder(){
		if (maxGuessAllowed == 0) {
			text2.text = "最後回！";
		}else {
			text2.text = "あと" + maxGuessAllowed +"回";
		}
	}
}
