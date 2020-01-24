using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class profile : MonoBehaviour
{
    public Text text_profil;
	public InputField inputfield;

	private void Start () {
		text_profil.text = My_Text.MyText;
	}
	public void LoadText()
	{
		My_Text.MyText = inputfield.text;
	}
}