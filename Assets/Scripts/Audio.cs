using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Audio: MonoBehaviour
{
	public AudioClip myAudioClip;
	//float timeRemaining = 10;
	public Text Text;

	public void AudioInput(){
		myAudioClip = Microphone.Start(null, false, 10, 44100);
		Text.text = "録音中…";
		Debug.Log ("Recording");
	}

	public void AudioOutput(){
		AudioSource audio = GetComponent<AudioSource>();
		audio.clip = myAudioClip;
		audio.Play();
		Text.text = "音再生中:)";
		Debug.Log ("Playing");
	}
		
	/*void CountDown(){
		timeRemaining -= Time.deltaTime;
		if (timeRemaining > 0) {
			Text.text = "録音中…\n " + "あと" + Mathf.Round(timeRemaining) + "秒";
		} else if (timeRemaining <= 0){
			Text.text = "録音終了！！";
		}
	}*/
}
