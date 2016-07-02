using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayingGame : MonoBehaviour {

	public GameObject Card1;
	public GameObject Card2;
	public GameObject Player1Score;
	public GameObject Player2Score;
	public bool Player1Turn;
	public bool Player2Turn;
	public bool PlayerGo;
	public bool TwoCardsPicked;
	public bool PickNewCard;
	public bool ReadyForAnother;
	public float CardsLeft;
	public Image EndGame;
	public Color ScreenColour = Color.black;
	public Text Win;
	public GameObject TimerImage;
	public GameObject OptionButtons;
	public float FadeOutTime =4f;
	public bool GameStarted;
	private float PickingTime =0.3f;
	public float CheckTime = 1.5f;
	private Click click;
	private bool Used = false;
	private Score score;
	private float Player1EndScore;
	private float Player2EndScore;
	public GameObject MainMenu;
	public bool TwoMatched;
	public GameObject GameTimer;
	public GameObject AIPlayer;
	private AIScript aiscript;
	private bool Added;
	private float LastWins;
	private float LastVSWin;
	private float LastVSLoss;
	private float LastVSDraw;




	// Use this for initialization
	void Start () 
	{
		LastWins = (PlayerPrefs.GetFloat("Match Win"));
		LastVSWin = (PlayerPrefs.GetFloat("AI Win"));
		LastVSLoss = (PlayerPrefs.GetFloat("AI Loss"));
		LastVSDraw = (PlayerPrefs.GetFloat("AI Draw"));
		if (Player1Turn == true && Used == false) 
		{
			Player1Score = GameObject.FindWithTag ("Player1Score");
			Player2Score = GameObject.FindWithTag ("Player2Score");
			Used = true;
		}
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

		if (Card1 != null && Card2 == null && CheckTime <= 1.5f) 
		{
			CheckTime = 1.5f;
		}

		if (Card1 != null && Card2 == null && TwoCardsPicked == true) 
		{
			TwoCardsPicked = false;
			PickNewCard = true;
			ReadyForAnother = true;
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
				TwoMatched = true;
				//PlayerGo = true;

			if (Player1Turn == true && TwoMatched == true) 
			{
//				PlayerGo = false;
//				Player1Turn = false;
//				Player2Turn = true;
				score = Player1Score.GetComponent<Score> ();
				score.ScoreValue += 2;
			}

			if (Player2Turn == true && TwoMatched == true) 
			{
//				PlayerGo = false;
//				Player2Turn = false;
//				Player1Turn = true;
				score = Player2Score.GetComponent<Score> ();
				score.ScoreValue += 2;
			}
			}

			if (Card1 != null && Card2 != null && Card1.tag != Card2.tag && CheckTime <= 0) {
				Card1.transform.eulerAngles = new Vector3 (gameObject.transform.rotation.x, gameObject.transform.rotation.y, 177.7483f);
				Card2.transform.eulerAngles = new Vector3 (gameObject.transform.rotation.x, gameObject.transform.rotation.y, 177.7483f);
				CheckTime = 1.5f;
				TwoCardsPicked = false;
				Card1 = null;
				Card2 = null;
				PlayerGo = true;

			if (Player1Turn == true && PlayerGo == true) 
			{
				PlayerGo = false;
				Player1Turn = false;
				Player2Turn = true;
			}

			if (Player2Turn == true && PlayerGo == true) 
			{
				PlayerGo = false;
				Player2Turn = false;
				Player1Turn = true;
			}
			}
	}

	void FixedUpdate ()
	{
		if (FadeOutTime <= 0) 
		{
			if (GameTimer != null) 
			{
				Destroy (GameTimer);
			}
			Win.text = "You Won!";
			if (OptionButtons.activeInHierarchy == false)
			{
				OptionButtons.SetActive (true);
				Destroy (MainMenu);
			}

			if (Player1Turn == false && Player2Turn == false)
				{
					PlayerPrefs.SetFloat("Match Win", LastWins+1);
				}
		}

		if (FadeOutTime <= 0 && Player1Turn == true) 
		{
			score = Player1Score.GetComponent<Score> ();
			Player1EndScore = score.ScoreValue;
			score = Player2Score.GetComponent<Score> ();
			Player2EndScore = score.ScoreValue;

			if (Player1EndScore >= Player2EndScore)
			{
				Win.text = "Player 1 Wins!";

				if (AIPlayer.activeSelf == true && Added == false) 
				{
					aiscript = AIPlayer.GetComponent<AIScript> ();

					if (aiscript.IsPlayer1 == true && Added == false) 
					{
						PlayerPrefs.SetFloat("AI Loss", LastVSLoss +1);
						Added = true;
					}

					if (aiscript.IsPlayer1 == false && Added == false) 
					{
						PlayerPrefs.SetFloat("AI Win", LastVSWin +1);
						Added = true;
					}
				}

				if (OptionButtons.activeInHierarchy == false) 
				{
					OptionButtons.SetActive (true);
					Destroy (MainMenu);
				}
			}

			if (Player1EndScore <= Player2EndScore)
			{
				Win.text = "Player 2 Wins!";

				if (AIPlayer.activeSelf == true && Added == false) 
				{
					aiscript = AIPlayer.GetComponent<AIScript> ();

					if (aiscript.IsPlayer2 == true && Added == false) 
					{
						PlayerPrefs.SetFloat("AI Loss",LastVSLoss +1);
						Added = true;
					}

					if (aiscript.IsPlayer2 == false && Added == false) 
					{
						PlayerPrefs.SetFloat("AI Win",LastVSWin +1);
						Added = true;
					}
				}
				if (OptionButtons.activeInHierarchy == false) 
				{
					OptionButtons.SetActive (true);
					Destroy (MainMenu);
				}
			}

			if (Player1EndScore == Player2EndScore)
			{
				Win.text = "    Draw!";

				if (AIPlayer.activeSelf == true && Added == false) 
				{
					PlayerPrefs.SetFloat("AI Draw",LastVSDraw +1);
					Added = true;
				}

				if (OptionButtons.activeInHierarchy == false) 
				{
					OptionButtons.SetActive (true);
					Destroy (MainMenu);
				}
			}
		}

		if (FadeOutTime <= 0 && Player2Turn == true) 
		{
			score = Player1Score.GetComponent<Score> ();
			Player1EndScore = score.ScoreValue;
			score = Player2Score.GetComponent<Score> ();
			Player2EndScore = score.ScoreValue;

			if (Player1EndScore >= Player2EndScore)
			{
				Win.text = "Player 1 Wins!";

				if (AIPlayer.activeSelf == true && Added == false) 
				{
					aiscript = AIPlayer.GetComponent<AIScript> ();

					if (aiscript.IsPlayer1 == true && Added == false) 
					{
						PlayerPrefs.SetFloat("AI Loss",LastVSLoss +1);
						Added = true;
					}

					if (aiscript.IsPlayer1 == false && Added == false) 
					{
						PlayerPrefs.SetFloat("AI Win",LastVSWin +1);
						Added = true;
					}
				}


				if (OptionButtons.activeInHierarchy == false) 
				{
					OptionButtons.SetActive (true);
					Destroy (MainMenu);
				}
			}

			if (Player1EndScore <= Player2EndScore)
			{
				Win.text = "Player 2 Wins!";

				if (AIPlayer.activeSelf == true && Added == false) 
				{
					aiscript = AIPlayer.GetComponent<AIScript> ();

					if (aiscript.IsPlayer2 == true && Added == false) 
					{
						PlayerPrefs.SetFloat("AI Loss",LastVSLoss +1);
						Added = true;
					}

					if (aiscript.IsPlayer2 == false && Added == false) 
					{
						PlayerPrefs.SetFloat("AI Win",LastVSWin +1);
						Added = true;
					}
				}

				if (OptionButtons.activeInHierarchy == false) 
				{
					OptionButtons.SetActive (true);
					Destroy (MainMenu);
				}
			}

			if (Player1EndScore == Player2EndScore)
			{
				Win.text = "    Draw!";

				if (AIPlayer.activeSelf == true && Added == false) 
				{
					PlayerPrefs.SetFloat("AI Draw",LastVSDraw +1);
					Added = true;
				}
				if (OptionButtons.activeInHierarchy == false) 
				{
					OptionButtons.SetActive (true);
					Destroy (MainMenu);
				}
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

