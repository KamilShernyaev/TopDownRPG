using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadGameButton : MonoBehaviour 
{
	public Button loadButton;
	private string checkData;
	public static bool loadData;
	
	void Start()
	{
		checkData = PlayerPrefs.GetString("Enable Load");
		
		if(checkData == "True")
		{
			loadButton.interactable = true;
			loadData = true;
		}else
		{
			loadButton.interactable = false;
		}
	}
		
	public void LoadScene(int intScene)
	{
		SceneManager.LoadScene(intScene);
	}
}
