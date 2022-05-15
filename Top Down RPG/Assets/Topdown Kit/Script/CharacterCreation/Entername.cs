using UnityEngine;
using UnityEngine.UI;

public class Entername : MonoBehaviour 
{
	public InputField textArea;
    public Text buttonText;
	public string defaultName; 
	public void NameCharacter() 
	{
		defaultName = textArea.text;

		if(defaultName == "")
		{
			defaultName = "Your Name";
		}

		buttonText.text = defaultName;
	}
}
