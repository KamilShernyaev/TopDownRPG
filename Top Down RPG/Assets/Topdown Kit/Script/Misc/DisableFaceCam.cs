using UnityEngine;
using System.Collections;

public class DisableFaceCam : MonoBehaviour 
{
	void Start () 
	{
		if(GameSetting.Instance.disableFaceRender)
		{
			this.gameObject.SetActive(false);
		}
	}
}
