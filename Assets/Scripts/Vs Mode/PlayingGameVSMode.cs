using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayingGameVSMode : MonoBehaviour {

	public GameObject Card1;
	public GameObject Card2;
	public Text Player1Score;
	public Text Player2Score;
	public bool TwoCardsPicked;
	public bool PickNewCard;
	public bool ReadyForAnother;
	public float CardsLeft;
	public Image EndGame;
	public Color ScreenColour = Color.black;
	public Text Win;
	public GameObject TimerImage;
	public GameObject OptionButtons;
	private float FadeOutTime =4f;
	public bool GameStarted;
	private float PickingTime =0.3f;
	public float CheckTime = 1.5f;
	public bool Player1Turn;
	public bool Player2Turn;
	private Click click;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (CardsLeft >= 1) 
		{
			GameStarted = true;
		}
		
			if (Card1 != null && Card2 != null) {
				TwoCardsPicked = true;
			}

			if (TwoCardsPicked == true) {
				CheckTime -= Time.deltaTime;
			}

			if (Card1 == Card2) {
				Card2 = null;
			}

			if (Card1 != null && Card2 != null && Card1.tag == Card2.tag && CheckTime <= 0)
		{
				click =	Card1.GetComponent <Click> ();
				CardsLeft -= click.Card;
				click =	Card2.GetComponent <Click> ();
				CardsLeft -= click.Card;
				Destroy (Card1);
				Destroy (Card2);
				CheckTime = 1.5f;
				TwoCardsPicked = false;

			if (Player1Turn == true) 
			{
				Player1Turn = false;
				Player2Turn = true;
			}

			if (Player2Turn == true) 
			{
				Player2Turn = false;
				Player1Turn = true;
			}
			}

			if (Card1 != null && Card2 != null && Card1.tag != Card2.tag && CheckTime <= 0) 
		{
				Card1.transform.eulerAngles = new Vector3 (gameObject.transform.rotation.x, gameObject.transform.rotation.y, 177.7483f);
				Card2.transform.eulerAngles = new Vector3 (gameObject.transform.rotation.x, gameObject.transform.rotation.y, 177.7483f);
				CheckTime = 1.5f;
				TwoCardsPicked = false;
				Card1 = null;
				Card2 = null;
			if (Player1Turn == true) 
			{
				Player1Turn = false;
				Player2Turn = true;
			}

			if (Player2Turn == true) 
			{
				Player2Turn = false;
				Player1Turn = true;
			}
			}
	}

	void FixedUpdate ()
	{
		if (FadeOutTime <= 0) 
		{
			Win.text = "You Won!";
			if (OptionButtons.activeInHierarchy == false)
			{
				OptionButtons.SetActive (true);
			}
		}

			if (ReadyForAnother == true) 
			{
				PickingTime -= Time.deltaTime;
			}

			if (PickingTime <= 0)
			{
				PickNewCard = true;
				ReadyForAnother = false;
				PickingTime = 0.3f;
			}

		if (GameStarted == true && CardsLeft <= 0) 
		{
			if (TimerImage != null)
			{
				Destroy (TimerImage);
			}
			ScreenColour.a = EndGame.color.a + .006f;
			EndGame.color = ScreenColour;
			FadeOutTime -= Time.deltaTime;
		}
		}
	}

