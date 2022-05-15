using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewGameButton : MonoBehaviour 
{
	public void LoadScene(int intScene)
	{
		SceneManager.LoadScene(intScene);;	
	}
}
