using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	public void ChangeToScene (string scenetoChangeTo){
		SceneManager.LoadScene (scenetoChangeTo);
	}

	public void SaveCurrentLevel()
	{
		Scene currentScene = SceneManager.GetActiveScene();
		PlayerPrefs.SetString ("PlayerProgress", currentScene.name);
	}

	public void LoadCurrentLevel()
	{
		SceneManager.LoadScene(PlayerPrefs.GetString("PlayerProgress", "CurrentScene.name"));
	}

}
