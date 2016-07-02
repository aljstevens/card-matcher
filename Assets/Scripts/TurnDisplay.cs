using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TurnDisplay : MonoBehaviour {

	public GameObject GamePlayer;
	public GameObject Player1Image;
	public GameObject Player2Image;

	private PlayingGame playinggame;

	// Use this for initialization
	void Start () 
	{
		playinggame = GamePlayer.GetComponent <PlayingGame> ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (playinggame.Player1Turn == true)
		{
			Player1Image.SetActive (true);
			Player2Image.SetActive (false);
		}

		if (playinggame.Player2Turn == true)
		{
			Player2Image.SetActive (true);
			Player1Image.SetActive (false);
		}
	}
}
