using UnityEngine;

public class ControlTitleScene : MonoBehaviour 
{
	public GameObject titleMenu;
	public Transform targetPoint;
	public float lastPosition;
	public int speedCamera;
	
	private void Start() 
	{
		titleMenu.SetActive(false);
	}
	void Update () 
	{
		transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speedCamera * Time.deltaTime);	
		
		if(transform.position.z >= lastPosition)
		{
			titleMenu.SetActive(true);
			speedCamera = 0;
		}
	}
}
