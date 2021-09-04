using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

	public GameObject loading;

	public void startthegame (string startgame)
	{
		SceneManager.LoadScene ("Main");
		loading.SetActive (true);
	}
	public void quitthegame (string quit)
	{
		Application.Quit();
	}
}
