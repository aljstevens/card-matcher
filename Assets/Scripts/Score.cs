using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public float ScoreValue;
	public Text ScoreText;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		ScoreText.text = "" + ScoreValue.ToString ();
	}
}