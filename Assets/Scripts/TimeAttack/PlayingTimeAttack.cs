using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayingTimeAttack : MonoBehaviour {

	public GameObject Card1;
	public GameObject Card2;
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
	private ClickTimeAttack click;
	public GameObject Round;
	public GameObject MainMenu;

	public TimerTimeAttack timertimeattack; 
	public GameObject TimerObject;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (TimerObject == null) 
		{
			TimerObject = GameObject.FindWithTag ("Timer");
			if (TimerObject != null) 
			{
				timertimeattack = TimerObject.GetComponent <TimerTimeAttack> ();
			}
		}
			

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
				click =	Card1.GetComponent <ClickTimeAttack> ();
				CardsLeft -= click.Card;
				click =	Card2.GetComponent <ClickTimeAttack> ();
				CardsLeft -= click.Card;
				Destroy (Card1);
				Destroy (Card2);
				timertimeattack.secondstext += 3f;
				timertimeattack.Seconds += 3f;
				CheckTime = 1.5f;
				TwoCardsPicked = false;
			}

			if (Card1 != null && Card2 != null && Card1.tag != Card2.tag && CheckTime <= 0) {
				Card1.transform.eulerAngles = new Vector3 (gameObject.transform.rotation.x, gameObject.transform.rotation.y, 177.7483f);
				Card2.transform.eulerAngles = new Vector3 (gameObject.transform.rotation.x, gameObject.transform.rotation.y, 177.7483f);
				CheckTime = 1.5f;
				TwoCardsPicked = false;
				click =	Card1.GetComponent <ClickTimeAttack> ();
				click.Flipped = false;
				click =	Card2.GetComponent <ClickTimeAttack> ();
				click.Flipped = false;
				Card1 = null;
				Card2 = null;
			}
	}

	void FixedUpdate ()
	{
		if (FadeOutTime <= 0) 
		{
			Win.text = "Round Complete!";
			if (OptionButtons.activeInHierarchy == false)
			{
				OptionButtons.SetActive (true);
				timertimeattack.tag = ("LastTimer");
				Round.tag = ("LastRound");
				Destroy (MainMenu);
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
			ScreenColour.a = EndGame.color.a + .006f;
			EndGame.color = ScreenColour;
			FadeOutTime -= Time.deltaTime;

			if (TimerImage.activeSelf == true)
				{
					TimerImage.SetActive (false);
				}
		}
		}
	}

