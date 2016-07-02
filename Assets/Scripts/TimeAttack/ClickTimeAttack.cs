using UnityEngine;
using System.Collections;

public class ClickTimeAttack : MonoBehaviour {

	public bool Clicked;
	public bool Flipped;
	public float Card =1f;

	private GameObject Player;
	private PlayingTimeAttack playgame;
	private GameObject TimerObject;
	private TimerTimeAttack timer;

	void Awake ()
	{
		Player = GameObject.FindWithTag ("Player");
		playgame = Player.GetComponent <PlayingTimeAttack> ();
		TimerObject = GameObject.FindWithTag ("Timer");
		if (TimerObject != null) 
		{
			timer = TimerObject.GetComponent <TimerTimeAttack> ();
		}
		playgame.CardsLeft += Card;
	}

	void OnMouseDown()
	{
		if (playgame.Card1 == null && playgame.Card2 == null) 
		{
			Debug.Log ("Breow");
			playgame.Card1 = gameObject;
			Clicked = true;
			Flipped = true;
			playgame.ReadyForAnother = true;
		}

		if (Flipped == false && playgame.Card1 != null && playgame.Card2 == null && playgame.PickNewCard == true) 
		{
			Debug.Log ("Brump");
			playgame.Card2 = gameObject;
			Clicked = true;
			Flipped = true;
			playgame.PickNewCard = false;
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

