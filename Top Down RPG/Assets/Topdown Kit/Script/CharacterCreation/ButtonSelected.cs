using UnityEngine;
using UnityEngine.UI;

public class ButtonSelected : MonoBehaviour 
{
	public SelectCharacter selectCharacterScript;
	
	public void NextCharacter()
	{
		selectCharacterScript.indexHero += 1;
		if(selectCharacterScript.indexHero >= selectCharacterScript.hero.Length)
		{
			selectCharacterScript.indexHero = 0;
		}
		selectCharacterScript.UpdateHero(selectCharacterScript.indexHero);
	}

	public void PreviouslyCharacter()
	{
		selectCharacterScript.indexHero -= 1;	
		
		if(selectCharacterScript.indexHero < 0)
		{
			selectCharacterScript.indexHero = selectCharacterScript.hero.Length-1;
		}
		selectCharacterScript.UpdateHero(selectCharacterScript.indexHero);
	}
}
