using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SaveandLoadScene : MonoBehaviour
{

	public void SaveCurrentLevel()
	{
		Scene currentScene = SceneManager.GetActiveScene();
		PlayerPrefs.SetString ("PlayerProgress", currentScene.name);
	}

	public void LoadCurrentLevel() //Call this when player hits 'P' or Play button etc.
	{
		SceneManager.LoadScene(PlayerPrefs.GetString("PlayerProgress", "CurrentScene.name"));
	}
}