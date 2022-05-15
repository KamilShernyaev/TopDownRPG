using UnityEngine;
using UnityEngine.UI;

public class SelectCharacter : MonoBehaviour 
{
	public GameObject[] hero;
	public Button buttonNext,buttonPrev;

	[HideInInspector]
	public int indexHero = 0;  //index select hero
	private GameObject[] heroInstance;

	void Start () 
	{
		heroInstance = new GameObject[hero.Length];
		indexHero = 0;
		SpawnHero();

		if(hero.Length <= 1)
		{
			buttonNext.gameObject.SetActive(false);
			buttonPrev.gameObject.SetActive(false);
		}
	}
	
	public void UpdateHero(int _indexHero)
	{
		for(int i=0; i<hero.Length;i++)
		{
			if(i == _indexHero)
			{
				heroInstance[i].SetActive(true);
			}else
			{
				heroInstance[i].SetActive(false);
			}		
		}
	}

	public void SpawnHero()
	{
		for(int i=0;i<hero.Length;i++)
		{
			heroInstance[i] = (GameObject)Instantiate(hero[i],transform.position,transform.rotation);
		}
		
		UpdateHero(indexHero);
	}
	
}
