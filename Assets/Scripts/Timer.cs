using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	public float Seconds;
	public float secondstext;
	public float Mins;
	public float minstext;
	public Text TimerNumber;
	public Text TimerNumber2;
	public GameObject TimerImage;
	public GameObject OptionButtons;
	public GameObject Player;

	public Image EndGame;
	public Color ScreenColour = Color.black;
	public Text Win;
	private float FadeOutTime =4f;
	private float LastLoss;

	// Use this for initialization
	void Start ()
	{
		LastLoss = (PlayerPrefs.GetFloat("Quick Loss"));
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (FadeOutTime <= 0) 
		{
			if (Player != null)
			{
				Destroy (Player);
			}
			Win.text = "You Lose!";

			if (OptionButtons.activeInHierarchy == false)
			{
				OptionButtons.SetActive (true);
				PlayerPrefs.SetFloat("Quick Loss",LastLoss +1);
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

		secondstext -= Time.deltaTime;
		Seconds = Mathf.Round (secondstext);
		//TimerNumber.text = "" + Seconds.ToString ();
		Mins = Mathf.Round (minstext);
		TimerNumber2.text = "" + minstext.ToString ();

	}
}
