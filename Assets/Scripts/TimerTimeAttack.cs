using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimerTimeAttack : MonoBehaviour {

	public float Seconds;
	public float secondstext;
	public float Mins;
	public float minstext;
	public Text TimerNumber;
	public Text TimerNumber2;
	public GameObject TimerImage;
	public GameObject OptionButtons;
	public GameObject LastTimer;
	public GameObject NextRound;
	public GameObject MainMenu;

	public Image EndGame;
	public Color ScreenColour = Color.black;
	public Text Win;
	private float FadeOutTime =4f;
	private GameObject PlayerObject;
	private PlayingTimeAttack playingtimeattack;
	private TimerTimeAttack timertimeattack;

	// Use this for initialization
	void Awake ()
	{
		PlayerObject = GameObject.FindWithTag ("Player");
		playingtimeattack = PlayerObject.GetComponent <PlayingTimeAttack> ();
		DontDestroyOnLoad(transform.gameObject);
		LastTimer = GameObject.FindWithTag ("LastTimer");
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (LastTimer != null)
		{
			timertimeattack = LastTimer.GetComponent <TimerTimeAttack> ();
			Seconds = timertimeattack.Seconds;
			secondstext = timertimeattack.secondstext;
			Mins = timertimeattack.Mins;
			minstext = timertimeattack.minstext;
			Destroy (LastTimer);
		}
		
		if (FadeOutTime <= 0) 
		{
			Win.text = "Game Over!";

			if (OptionButtons.activeInHierarchy == false)
			{
				OptionButtons.SetActive (true);
				Destroy (NextRound);
				Destroy (MainMenu);
			}
				
		}


		if (Mins <= 0 && Seconds <= 0) 
		{
			if (TimerImage != null)
			{
				Destroy (TimerImage);
			}
			ScreenColour.a = EndGame.color.a + .006f;
			EndGame.color = ScreenColour;
			FadeOutTime -= Time.deltaTime;
		}

		if (secondstext >= 59.50) 
		{
			secondstext -= 60f;
			minstext += 1;
		}

		if (secondstext <=9.50 && TimerNumber != null)
		{
			TimerNumber.text = "0" + Seconds.ToString ();
		}

		if (secondstext >=9.50 && TimerNumber != null)
		{
			TimerNumber.text = "" + Seconds.ToString ();
		}


		if (secondstext <= 0 && minstext >=1) 
		{
			secondstext = 59.50f;
			minstext -= 1;
		}

		if (playingtimeattack.CardsLeft >= 1) 
		{
			secondstext -= Time.deltaTime;
			Seconds = Mathf.Round (secondstext);
			//TimerNumber.text = "" + Seconds.ToString ();
			Mins = Mathf.Round (minstext);
			TimerNumber2.text = "" + minstext.ToString ();
		}

	}
}
