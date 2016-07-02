using UnityEngine;
using System.Collections;

public class AIScript : MonoBehaviour {

	public GameObject Ace1;
	public GameObject Ace2;
	public GameObject King1;
	public GameObject King2;
	public GameObject Queen1;
	public GameObject Queen2;
	public GameObject Jack1;
	public GameObject Jack2;
	public GameObject Ten1;
	public GameObject Ten2;
	public GameObject Nine1;
	public GameObject Nine2;
	public GameObject Eight1;
	public GameObject Eight2;
	public GameObject Seven1;
	public GameObject Seven2;

	public GameObject Pick1;
	public GameObject Pick2;
	public bool Skip;
	public bool Used;
	public float Timer =2f;
	public float PickTimer =1f;

	public GameObject Spot1;
	public GameObject Spot2;
	public GameObject Spot3;
	public GameObject Spot4;
	public GameObject Spot5;
	public GameObject Spot6;
	public GameObject Spot7;
	public GameObject Spot8;
	public GameObject Spot9;
	public GameObject Spot10;
	public GameObject Spot11;
	public GameObject Spot12;
	public GameObject Spot13;
	public GameObject Spot14;
	public GameObject Spot15;
	public GameObject Spot16;

	public bool IsHard;
	public bool IsNormal;
	public bool IsEasy;
	public bool CountDown;
	public bool IsPlayer1;
	public bool IsPlayer2;
	public bool Moved;
	public float ThinkingTime;
	public GameObject ClosestTarget;
	public bool Card1Flipped;
	public bool Card2Flipped;
	public bool FirstMove;
	public bool ReadyToMatch;
	public bool ChanceTest;
	public float Chance;

	private float StartingPosition;
	public float CardsSelected;
	public float CardPicker;
	public GameObject PlayingObject;
	private PlayingGame playinggame;

	void Awake ()
	{
		playinggame = PlayingObject.GetComponent <PlayingGame> ();

	}

	// Use this for initialization
	void Start () {

	}

	GameObject FindClosestEnemy()
	{
		GameObject[] gos;
		gos = GameObject.FindGameObjectsWithTag("Target");
		GameObject closest = null;
		float distance = Mathf.Infinity;
		Vector3 position = transform.position;
		foreach (GameObject go in gos) {
			Vector3 diff = go.transform.position - position;
			float curDistance = diff.sqrMagnitude;
			if (curDistance < distance) {
				closest = go;
				distance = curDistance;
			}
		}
		return closest;
	}

	// Update is called once per frame
	void Update () 
	{
		if (Ace1 == Ace2)
		{
			Ace2 = null;
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("Ace") && Ace1 == null)
		{
			Ace1 = playinggame.Card1;
			if (Ace1 == Ace2)
			{
				Ace2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("Ace") && Ace1 == null)
		{
			Ace1 = playinggame.Card2;
			if (Ace1 == Ace2)
			{
				Ace2 = null;
			}
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("Ace") && Ace2 == null)
		{
			Ace2 = playinggame.Card1;
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("Ace") && Ace2 == null)
		{
			Ace2 = playinggame.Card2;
			if (Ace1 == Ace2)
			{
				Ace2 = null;
			}
		}

		if (King1 == King2)
		{
			King2 = null;
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("King") && King1 == null)
		{
			King1 = playinggame.Card1;
			if (King1 == King2)
			{
				King2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("King") && King1 == null)
		{
			King1 = playinggame.Card2;
			if (King1 == King2)
			{
				King2 = null;
			}
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("King") && King2 == null)
		{
			King2 = playinggame.Card1;
			if (King1 == King2)
			{
				King2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("King") && King2 == null)
		{
			King2 = playinggame.Card2;
			if (King1 == King2)
			{
				King2 = null;
			}
		}

		if (Queen1 == Queen2)
		{
			Queen2 = null;
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("Queen") && Queen1 == null)
		{
			Queen1 = playinggame.Card1;
			if (Queen1 == Queen2)
			{
				Queen2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("Queen") && Queen1 == null)
		{
			Queen1 = playinggame.Card2;
			if (Queen1 == Queen2)
			{
				Queen2 = null;
			}
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("Queen") && Queen2 == null)
		{
			Queen2 = playinggame.Card1;
			if (Queen1 == Queen2)
			{
				Queen2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("Queen") && Queen2 == null)
		{
			Queen2 = playinggame.Card2;
			if (Queen1 == Queen2)
			{
				Queen2 = null;
			}
		}

		if (Jack1 == Jack2)
		{
			Jack2 = null;
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("Jack") && Jack1 == null)
		{
			Jack1 = playinggame.Card1;
			if (Jack1 == Jack2)
			{
				Jack2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("Jack") && Jack1 == null)
		{
			Jack1 = playinggame.Card2;
			if (Jack1 == Jack2)
			{
				Jack2 = null;
			}
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("Jack") && Jack2 == null)
		{
			Jack2 = playinggame.Card1;
			if (Jack1 == Jack2)
			{
				Jack2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("Jack") && Jack2 == null)
		{
			Jack2 = playinggame.Card2;
			if (Jack1 == Jack2)
			{
				Jack2 = null;
			}
		}

		if (Ten1 == Ten2)
		{
			Ten2 = null;
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("10") && Ten1 == null)
		{
			Ten1 = playinggame.Card1;
			if (Ten1 == Ten2)
			{
				Ten2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("10") && Ten1 == null)
		{
			Ten1 = playinggame.Card2;
			if (Ten1 == Ten2)
			{
				Ten2 = null;
			}
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("10") && Ten2 == null)
		{
			Ten2 = playinggame.Card1;
			if (Ten1 == Ten2)
			{
				Ten2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("10") && Ten2 == null)
		{
			Ten2 = playinggame.Card2;
			if (Ten1 == Ten2)
			{
				Ten2 = null;
			}
		}

		if (Nine1 == Nine2)
		{
			Nine2 = null;
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("9") && Nine1 == null)
		{
			Nine1 = playinggame.Card1;
			if (Nine1 == Nine2)
			{
				Nine2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("9") && Nine1 == null)
		{
			Nine1 = playinggame.Card2;
			if (Nine1 == Nine2)
			{
				Nine2 = null;
			}
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("9") && Nine2 == null)
		{
			Nine2 = playinggame.Card1;
			if (Nine1 == Nine2)
			{
				Nine2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("9") && Nine2 == null)
		{
			Nine2 = playinggame.Card2;
			if (Nine1 == Nine2)
			{
				Nine2 = null;
			}
		}

		if (Eight1 == Eight2)
		{
			Eight2 = null;
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("8") && Eight1 == null)
		{
			Eight1 = playinggame.Card1;
			if (Eight1 == Eight2)
			{
				Eight2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("8") && Eight1 == null)
		{
			Eight1 = playinggame.Card2;
			if (Eight1 == Eight2)
			{
				Eight2 = null;
			}
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("8") && Eight2 == null)
		{
			Eight2 = playinggame.Card1;
			if (Eight1 == Eight2)
			{
				Eight2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("8") && Eight2 == null)
		{
			Eight2 = playinggame.Card2;
			if (Eight1 == Eight2)
			{
				Eight2 = null;
			}
		}

		if (Seven1 == Seven2)
		{
			Seven2 = null;
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("7") && Seven1 == null)
		{
			Seven1 = playinggame.Card1;
			if (Seven1 == Seven2)
			{
				Seven2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("7") && Seven1 == null)
		{
			Seven1 = playinggame.Card2;
			if (Seven1 == Seven2)
			{
				Seven2 = null;
			}
		}

		if (playinggame.Card1 != null && playinggame.Card1.tag == ("7") && Seven2 == null)
		{
			Seven2 = playinggame.Card1;
			if (Seven1 == Seven2)
			{
				Seven2 = null;
			}
		}

		if (playinggame.Card2 != null && playinggame.Card2.tag == ("7") && Seven2 == null)
		{
			Seven2 = playinggame.Card2;
			if (Seven1 == Seven2)
			{
				Seven2 = null;
			}
		}

		StartingPosition = Random.Range (1, 17);

		if (StartingPosition == 1 && FirstMove == false) 
		{
			transform.position = (Spot1.transform.position);
			FirstMove = true;
		}

		if (StartingPosition == 2 && FirstMove == false) 
		{
			transform.position = (Spot2.transform.position);
			FirstMove = true;
		}

		if (StartingPosition == 3 && FirstMove == false) 
		{
			transform.position = (Spot3.transform.position);
			FirstMove = true;
		}

		if (StartingPosition == 4 && FirstMove == false) 
		{
			transform.position = (Spot4.transform.position);
			FirstMove = true;
		}

		if (StartingPosition == 5 && FirstMove == false) 
		{
			transform.position = (Spot5.transform.position);
			FirstMove = true;
		}

		if (StartingPosition == 6 && FirstMove == false) 
		{
			transform.position = (Spot6.transform.position);
			FirstMove = true;
		}


		if (IsPlayer2 == true && playinggame.Player2Turn == false)
		{
			CardsSelected = 0;
			Pick1 = null;
			Pick2 = null;
			Card1Flipped = false;
			Card2Flipped = false;
			CardPicker = 0f;
			Moved = false;
			ChanceTest = true;
			Skip = false;
			Used = false;
		}

		if (IsPlayer1 == true && playinggame.Player1Turn == false)
		{
			CardsSelected = 0;
			Pick1 = null;
			Pick2 = null;
			Card1Flipped = false;
			Card2Flipped = false;
			CardPicker = 0f;
			Moved = false;
			ChanceTest = true;
			Skip = false;
			Used = false;
		}

		if (IsPlayer2 == true && playinggame.TwoMatched == true)
		{
			CardsSelected = 0;
			Pick1 = null;
			Pick2 = null;
			Card1Flipped = false;
			Card2Flipped = false;
			CardPicker = 0f;
			Moved = false;
			ChanceTest = true;
			Skip = false;
			Used = false;
			playinggame.TwoMatched = false;
		}

		if (IsPlayer1 == true && playinggame.TwoMatched == true)
		{
			CardsSelected = 0;
			Pick1 = null;
			Pick2 = null;
			Card1Flipped = false;
			Card2Flipped = false;
			CardPicker = 0f;
			Moved = false;
			ChanceTest = true;
			Skip = false;
			Used = false;
			playinggame.TwoMatched = false;
		}

		ClosestTarget = FindClosestEnemy ();

		if (IsPlayer1 == true && playinggame.Player1Turn == true && CardsSelected <= 2 && Moved == false)
		{		
			if (ChanceTest == true)
			{
				if (IsHard == true) 
				{
					Chance = Random.Range (1, 4);
					ChanceTest = false;
				}

				if (IsNormal == true) 
				{
					Chance = Random.Range (-1, 5);
					ChanceTest = false;
				}

				if (IsEasy == true) 
				{
					Chance = Random.Range (-1, 3);
					ChanceTest = false;
				}
			}
			CardPicker = Random.Range (1, 17);

			if (Ace1 != null && Ace2 != null && Ace1 != Ace2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Ace1;
					Pick2 = Ace2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (King1 != null && King2 != null && King1 != King2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = King1;
					Pick2 = King2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (Queen1 != null && Queen2 != null && Queen1 != Queen2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Queen1;
					Pick2 = Queen2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (Jack1 != null && Jack2 != null && Jack1 != Jack2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Jack1;
					Pick2 = Jack2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (Ten1 != null && Ten2 != null && Ten1 != Ten2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Ten1;
					Pick2 = Ten2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (Nine1 != null && Nine2 != null && Nine1 != Nine2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Nine1;
					Pick2 = Nine2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (Eight1 != null && Eight2 != null && Eight1 != Eight2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Eight1;
					Pick2 = Eight2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (Seven1 != null && Seven2 != null && Seven1 != Seven2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Seven1;
					Pick2 = Seven2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

		}

		if (IsPlayer2 == true && playinggame.Player2Turn == true && CardsSelected <= 2 && Moved == false)
		{		
			if (ChanceTest == true)
			{
				if (IsHard == true) 
				{
					Chance = Random.Range (1, 4);
					ChanceTest = false;
				}

				if (IsNormal == true) 
				{
					Chance = Random.Range (-1, 5);
					ChanceTest = false;
				}

				if (IsEasy == true) 
				{
					Chance = Random.Range (-1, 3);
					ChanceTest = false;
				}
			}
			CardPicker = Random.Range (1, 17);

			if (Ace1 != null && Ace2 != null && Ace1 != Ace2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Ace1;
					Pick2 = Ace2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (King1 != null && King2 != null && King1 != King2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = King1;
					Pick2 = King2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (Queen1 != null && Queen2 != null && Queen1 != Queen2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Queen1;
					Pick2 = Queen2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (Jack1 != null && Jack2 != null && Jack1 != Jack2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Jack1;
					Pick2 = Jack2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (Ten1 != null && Ten2 != null && Ten1 != Ten2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Ten1;
					Pick2 = Ten2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (Nine1 != null && Nine2 != null && Nine1 != Nine2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Nine1;
					Pick2 = Nine2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (Eight1 != null && Eight2 != null && Eight1 != Eight2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Eight1;
					Pick2 = Eight2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

			if (Seven1 != null && Seven2 != null && Seven1 != Seven2 && CardsSelected == 0 && Skip == false)
			{
				if (Chance >= 2) 
				{
					Debug.Log ("Their Here!");
					Pick1 = Seven1;
					Pick2 = Seven2;
					playinggame.Card1 = Pick1;
					playinggame.Card2 = Pick2;
					CardsSelected = 2;
				}

			}

		}


		if (Pick1 == Pick2)
		{
			Pick2 = null;
		}

		if (CardPicker == 1) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot1.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				CardPicker = 0;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 2) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot2.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//	Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 3) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot3.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 4) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot4.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 5) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot5.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 6) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot6.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 7) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot7.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 8) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot8.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 9) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot9.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 10) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot10.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 11) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot11.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 12) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot12.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 13) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot13.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 14) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot14.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 15) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot15.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}

		if (CardPicker == 16) 
		{
			ThinkingTime -=Time.deltaTime;
			transform.position = (Spot16.transform.position);
			Moved = true;


			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = ClosestTarget;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
				Moved = false;
				Skip = true;
				//Pick1.tag = ("Picked");
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0 && Skip == false)
			{
				Pick2 = ClosestTarget;
				Debug.Log ("?");
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
				Moved = false;
				Pick1.tag = ("Target");
				Pick2.tag = ("Target");
			}
		}
	}

	void FixedUpdate ()
	{
		if (CardsSelected == 1) 
		{
			Skip = true;
		}

		if (Skip == true) 
		{
			Timer -= Time.deltaTime;

			if (Pick1 == Ace2 && Ace1 != null && Ace1 != Ace2 && Chance >= 2 && CardsSelected == 1) {
				Debug.Log ("!");
				Used = true;
				PickTimer -= Time.deltaTime;
				if (PickTimer <=0)
				{
					Pick2 = Ace1;
					CardsSelected = 2;
					ThinkingTime = 1f;
					playinggame.Card2 = Pick2;
					Moved = false;
					CardPicker = 0;
					PickTimer = 1f;
				}
			}

			if (Pick1 == King2 && King1 != null && King1 != King2 && Chance >= 2 && CardsSelected == 1) {
				Debug.Log ("!");
				Used = true;
				PickTimer -= Time.deltaTime;
				if (PickTimer <=0)
				{
					Pick2 = King1;
					CardsSelected = 2;
					ThinkingTime = 1f;
					playinggame.Card2 = Pick2;
					Moved = false;
					CardPicker = 0;
					PickTimer = 1f;
				}
			}

			if (Pick1 == Queen2 && Queen1 != null && Queen1 != Queen2 && Chance >= 2 && CardsSelected == 1) {
				Debug.Log ("!");
				Used = true;
				PickTimer -= Time.deltaTime;
				if (PickTimer <=0)
				{
					Pick2 = Queen1;
					CardsSelected = 2;
					ThinkingTime = 1f;
					playinggame.Card2 = Pick2;
					Moved = false;
					CardPicker = 0;
					PickTimer = 1f;
				}
			}

			if (Pick1 == Jack2 && Jack1 != null && Jack1 != Jack2 && Chance >= 2 && CardsSelected == 1) {
				Debug.Log ("!");
				Used = true;
				PickTimer -= Time.deltaTime;
				if (PickTimer <=0)
				{
					Pick2 = Jack1;
					CardsSelected = 2;
					ThinkingTime = 1f;
					playinggame.Card2 = Pick2;
					Moved = false;
					CardPicker = 0;
					PickTimer = 1f;
				}
			}

			if (Pick1 == Ten2 && Ten1 != null && Ten1 != Ten2 && Chance >= 2 && CardsSelected == 1) {
				Debug.Log ("!");
				Used = true;
				PickTimer -= Time.deltaTime;
				if (PickTimer <=0)
				{
					Pick2 = Ten1;
					CardsSelected = 2;
					ThinkingTime = 1f;
					playinggame.Card2 = Pick2;
					Moved = false;
					CardPicker = 0;
					PickTimer = 1f;
				}
			}

			if (Pick1 == Nine2 && Nine1 != null && Nine1 != Nine2 && Chance >= 2 && CardsSelected == 1) {
				Debug.Log ("!");
				ThinkingTime = 1f;
				PickTimer -= Time.deltaTime;
				if (PickTimer <=0)
				{
					//Skip = true;
					Pick2 = Nine1;
					CardsSelected = 2;
					playinggame.Card2 = Pick2;
					Moved = false;
					CardPicker = 0;
					PickTimer = 1f;
				}
			}

			if (Pick1 == Eight2 && Eight1 != null && Eight1 != Eight2 && Chance >= 2 && CardsSelected == 1) {
				Debug.Log ("!");
				Used = true;
				PickTimer -= Time.deltaTime;
				if (PickTimer <=0)
				{
					Pick2 = Eight1;
					CardsSelected = 2;
					ThinkingTime = 1f;
					playinggame.Card2 = Pick2;
					Moved = false;
					CardPicker = 0;
					PickTimer = 1f;
				}
			}

			if (Pick1 == Seven2 && Seven1 != null && Seven1 != Seven2 && Chance >= 2 && CardsSelected == 1) 
			{
				Debug.Log ("!");
				Used = true;
				PickTimer -= Time.deltaTime;
				if (PickTimer <=0)
				{
					Pick2 = Seven1;
					CardsSelected = 2;
					ThinkingTime = 1f;
					playinggame.Card2 = Pick2;
					Moved = false;
					CardPicker = 0;
					PickTimer = 1f;
				}
			}
			if (Timer <= 0 && Used == false)
			{
				Skip = false;
				Timer = 2f;
			}
		}

		if (Pick1 != null && Pick1.transform.eulerAngles.z <= 18)
		{
			Card1Flipped = true;
		}

		if (Pick2 != null && Pick2.transform.eulerAngles.z <= 18)
		{
			Card2Flipped = true;
		}


		if (Pick1 != null && Pick1.transform.eulerAngles.z >= 18 && Card1Flipped == false)
		{
			Pick1.transform.Rotate (new Vector3 (0f, 0f, 0 + 400) * Time.deltaTime);
		}

		if (Pick2 != null && Pick2.transform.eulerAngles.z >= 18 && Card2Flipped == false)
		{
			Pick2.transform.Rotate (new Vector3 (0f, 0f, 0 + 400) * Time.deltaTime);
		}
	}
}
