using UnityEngine;
using System.Collections;

public class AI : MonoBehaviour {

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

	public float ChanceToRemeber;
	public GameObject PlayingObject;
	public bool IsPlayer1;
	public bool IsPlayer2;

	public float ThinkingTime =1f;
	private PlayingGame playinggame;
	private float ClearCards = 2f;
	public float CardsSelected;
	public float CardPicker;

	private bool Card1Flipped;
	private bool Card2Flipped;
	// Use this for initialization
	void Awake ()
	{
		playinggame = PlayingObject.GetComponent <PlayingGame> ();
		Spot1 = GameObject.FindWithTag ("AI-Ace1");
		Spot1.tag = ("Ace");
		Spot2 = GameObject.FindWithTag ("AI-Ace2");
		Spot2.tag = ("Ace");
		Spot3 = GameObject.FindWithTag ("AI-King1");
		Spot3.tag = ("King");
		Spot4 = GameObject.FindWithTag ("AI-King2");
		Spot4.tag = ("King");
		Spot5 = GameObject.FindWithTag ("AI-Queen1");
		Spot5.tag = ("Queen");
		Spot6 = GameObject.FindWithTag ("AI-Queen2");
		Spot6.tag = ("Queen");
		Spot7 = GameObject.FindWithTag ("AI-Jack1");
		Spot7.tag = ("Jack");
		Spot8 = GameObject.FindWithTag ("AI-Jack2");
		Spot8.tag = ("Jack");
		Spot9 = GameObject.FindWithTag ("AI-Ten1");
		Spot9.tag = ("10");
		Spot10 = GameObject.FindWithTag ("AI-Ten2");
		Spot10.tag = ("10");
		Spot11 = GameObject.FindWithTag ("AI-Nine1");
		Spot11.tag = ("9");
		Spot12 = GameObject.FindWithTag ("AI-Nine2");
		Spot12.tag = ("9");
		Spot13 = GameObject.FindWithTag ("AI-Eight1");
		Spot13.tag = ("8");
		Spot14 = GameObject.FindWithTag ("AI-Eight2");
		Spot14.tag = ("8");
		Spot15 = GameObject.FindWithTag ("AI-Seven1");
		Spot15.tag = ("7");
		Spot16 = GameObject.FindWithTag ("AI-Seven2");
		Spot16.tag = ("7");
	}

	// Update is called once per frame
	void Update ()
	{
//		if (Pick1.tag == ("Ace")) 
//		{
//			Ace1 = Pick1;
//		}

		if (IsPlayer1 == true && playinggame.Player1Turn == true && CardsSelected <= 2)
		{
			CardPicker = Random.Range (1, 16);
			Debug.Log ("Picked");
		}

		if (IsPlayer2 == true && playinggame.Player2Turn == true && CardsSelected <= 2)
		{
			CardPicker = Random.Range (1, 16);
			Debug.Log ("Picked");
		}

		if (IsPlayer1 == true && playinggame.Player1Turn == false)
		{
			CardsSelected = 0;
			ThinkingTime = 1f;
		}

		if (IsPlayer2 == true && playinggame.Player2Turn == false)
		{
			CardsSelected = 0;
			ThinkingTime = 1f;
		}

				if (Pick1 != null && Pick2 != null && ClearCards <=0) 
				{
					CardsSelected = 0;
					ClearCards = 2f;
					Pick1 = null;
					Pick2 = null;
					Card1Flipped = false;
					Card2Flipped = false;
				}
	}

	void FixedUpdate () 
	{
				if (Pick1 != null && Pick2 != null) 
				{
					ClearCards -= Time.deltaTime;
				}

		if (Pick1 == Pick2)
		{
			Pick2 = null;
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

		if (CardPicker == 1 && Spot1 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot1;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot1;
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 2 && Spot2 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot2;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot2;
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 3 && Spot3 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot3;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot3;
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 4 && Spot4 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot4;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot4;
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 5 && Spot5 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot5;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot5;
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 6 && Spot6 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot6;
				CardsSelected = 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot6;
				CardsSelected = 2;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 7 && Spot7 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot7;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot7;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 8 && Spot8 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot8;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot8;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 9 && Spot9 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot9;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot9;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 10 && Spot10 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot10;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot10;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 11 && Spot11 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot11;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot11;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}
		if (CardPicker == 12 && Spot12 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot12;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot12;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 13 && Spot13 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot13;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot13;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 14 && Spot14 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot14;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot14;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 15 && Spot15 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot15;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot15;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}

		if (CardPicker == 16 && Spot16 != null && CardsSelected <= 2) 
		{
			ThinkingTime -= Time.deltaTime;

			if (Pick1 == null && ThinkingTime <=0)
			{
				Pick1 = Spot16;
				CardsSelected += 1;
				ThinkingTime = 1f;
				playinggame.Card1 = Pick1;
			}

			if (Pick1 != null && Pick2 == null && ThinkingTime <=0)
			{
				Pick2 = Spot16;
				CardPicker += 1;
				ThinkingTime = 1f;
				playinggame.Card2 = Pick2;
			}

			if (Pick1 == Pick2 && ThinkingTime <=0)
			{
				Pick2 = null;
			}
		}
	}
}
