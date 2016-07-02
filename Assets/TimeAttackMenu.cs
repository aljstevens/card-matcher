using UnityEngine;
using System.Collections;

public class TimeAttackMenu : MonoBehaviour {

	public GameObject Round;
	public GameObject Timer;
	public GameObject LastRound;
	public GameObject LastTimer;

	// Use this for initialization
	void Awake () 
	{
		Round = GameObject.FindWithTag ("Round");
		Timer = GameObject.FindWithTag ("Timer");
		LastRound = GameObject.FindWithTag ("LastRound");
		LastTimer = GameObject.FindWithTag ("LastTimer");
	}

	// Update is called once per frame
	void Update ()
	{	
		Round = GameObject.FindWithTag ("Round");
		Timer = GameObject.FindWithTag ("Timer");
		LastRound = GameObject.FindWithTag ("LastRound");
		LastTimer = GameObject.FindWithTag ("LastTimer");

		if (Round != null)
		{
			Destroy (Round);
		}

		if (Timer != null) 
		{
			Destroy (Timer);
		}

		if (LastRound != null)
		{
			Destroy (LastRound);
		}

		if (LastTimer != null) 
		{
			Destroy (LastTimer);
		}

		if (Round == null && Timer == null && LastRound == null && LastTimer == null)
		{
			Application.LoadLevel("Title Screen");
			Destroy (Round);
		}
	}
}
