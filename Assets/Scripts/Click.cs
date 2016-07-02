using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {

	public bool Clicked;
	public bool Flipped;
	public float Card =1f;

	private GameObject Player;
	private PlayingGame playgame;
	private GameObject TimerObject;
	private Timer timer;
	private GameObject AI;
	private AIScript aiscript;

	private GameObject GM;
	private PlayingGame playinggame;

	void Awake ()
	{
		Player = GameObject.FindWithTag ("Player");
		playgame = Player.GetComponent <PlayingGame> ();

		AI = GameObject.FindWithTag ("AI");
		if (AI != null) 
		{
			aiscript = AI.GetComponent <AIScript> ();
		}

		GM = GameObject.FindWithTag ("Player");
		if (GM != null) 
		{
			playinggame = GM.GetComponent <PlayingGame> ();
		}

		TimerObject = GameObject.FindWithTag ("Timer");
		if (TimerObject != null) 
		{
			timer = TimerObject.GetComponent <Timer> ();
		}
		playgame.CardsLeft += Card;
	}

	void OnMouseDown()
	{
		if (AI != null && aiscript.IsPlayer1 == true && playinggame.Player2Turn == true && playgame.CheckTime == 1.5)
		{
			
			if (playgame.Card1 == null && playgame.Card2 == null) {
				playgame.Card1 = gameObject;
				Clicked = true;
				Flipped = true;
				playgame.ReadyForAnother = true;
			}

			if (playgame.Card1 != null && playgame.Card2 == null && playgame.PickNewCard == true) {
				playgame.Card2 = gameObject;
				Clicked = true;
				Flipped = true;
				playgame.PickNewCard = false;
			}
		}

		if (AI != null && aiscript.IsPlayer2 == true && playinggame.Player1Turn == true  && playgame.CheckTime == 1.5)
		{

			if (playgame.Card1 == null && playgame.Card2 == null) {
				playgame.Card1 = gameObject;
				Clicked = true;
				Flipped = true;
				playgame.ReadyForAnother = true;
			}

			if (playgame.Card1 != null && playgame.Card2 == null && playgame.PickNewCard == true) {
				playgame.Card2 = gameObject;
				Clicked = true;
				Flipped = true;
				playgame.PickNewCard = false;
			}
		}

		if (AI == null)
		{

			if (playgame.Card1 == null && playgame.Card2 == null) {
				playgame.Card1 = gameObject;
				Clicked = true;
				Flipped = true;
				playgame.ReadyForAnother = true;
			}

			if (playgame.Card1 != null && playgame.Card2 == null && playgame.PickNewCard == true) {
				playgame.Card2 = gameObject;
				Clicked = true;
				Flipped = true;
				playgame.PickNewCard = false;
			}
		}
	} 

	void FixedUpdate ()
	{
		if (TimerObject != null && timer.Mins <= 0 && timer.Seconds <= 0) 
			{
				enabled = false;
			}

			if (Clicked == true) {
				if (gameObject.transform.eulerAngles.z >= 18) 
				{
					transform.Rotate (new Vector3 (0f, 0f, 0 + 400) * Time.deltaTime);
				}
			}

			if (gameObject.transform.eulerAngles.z <= 18) 
			{
				Clicked = false;
				transform.eulerAngles = new Vector3 (gameObject.transform.rotation.x, gameObject.transform.rotation.y, 0);
			}
		}
}

