﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VSWin : MonoBehaviour {

	public float Value;
	public Text WinText;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update () 
	{
		Value = (PlayerPrefs.GetFloat("AI Win"));
		WinText.text = "" + Value.ToString ();
	}
}
