/// <summary>
/// This script use for detect button ok
/// To change texture button normal-down and call load scene when click this button
/// </summary>

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonOK : MonoBehaviour 
{
	public int numberScene;
	public Entername enterNameScript;
	public SelectCharacter selectCharacterScript;
	
	public void ConfirmCharacterSelection()
	{
		PlayerPrefs.SetString("pName",enterNameScript.defaultName);
		PlayerPrefs.SetInt("pSelect",selectCharacterScript.indexHero);
		
		SpawnPointHero.enableLoadData = true;
		
		Invoke("LoadScene",0.1f);
	}

	void LoadScene()
	{
		SceneManager.LoadScene(numberScene);	
	}
}
