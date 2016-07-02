using UnityEngine;
using System.Collections;

public class ChangeTag : MonoBehaviour {

	public string CardType;
	public GameObject PlayingObject;
	private PlayingGame playinggame;

	// Use this for initialization
	void Awake () 
	{
		PlayingObject = GameObject.FindWithTag ("Player");
		playinggame = PlayingObject.GetComponent <PlayingGame> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameObject == playinggame.Card1)
		{
			gameObject.tag = CardType;
		}

		if (gameObject == playinggame.Card2)
		{
			gameObject.tag = CardType;
		}

		if (gameObject.tag == CardType && gameObject != playinggame.Card1 && gameObject != playinggame.Card2 )
		{
			gameObject.tag = ("Target");
		}


	}
}
