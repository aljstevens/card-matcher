using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RoundNumber : MonoBehaviour
{
	public float RoundNumberAmount =1f;
	public GameObject LastRound;
	public Text RoundNumberImage;
	public float HighestScore;

	private bool Used=false;

	private RoundNumber roundnumber;

	// Use this for initialization
	void Awake ()
	{
		DontDestroyOnLoad(transform.gameObject);
		LastRound = GameObject.FindWithTag ("LastRound");
		HighestScore = (PlayerPrefs.GetFloat("HighestRound"));
	}
	
	// Update is called once per frame
	void Update ()
	{

		RoundNumberImage.text = "" + RoundNumberAmount.ToString ();
		if (LastRound != null && Used == false)
		{
			roundnumber = LastRound.GetComponent <RoundNumber> ();
			if (RoundNumberAmount >= HighestScore) 
			{
				PlayerPrefs.SetFloat ("HighestRound", RoundNumberAmount);
				HighestScore = (PlayerPrefs.GetFloat("HighestRound"));
			}
			RoundNumberAmount += roundnumber.RoundNumberAmount;
			Destroy (LastRound);
			Used = true;

		}
	}
}
