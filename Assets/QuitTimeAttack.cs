using UnityEngine;
using System.Collections;

public class QuitTimeAttack : MonoBehaviour {

	public GameObject Round;
	public GameObject Timer;

	// Use this for initialization
	void Awake () 
	{
		Round = GameObject.FindWithTag ("Round");
		Timer = GameObject.FindWithTag ("Timer");
	}
	
	// Update is called once per frame
	void Update ()
	{	
		Round = GameObject.FindWithTag ("Round");
		Timer = GameObject.FindWithTag ("Timer");

		if (Round != null)
		{
			Destroy (Round);
		}

		if (Timer != null) 
		{
			Destroy (Timer);
		}

		if (Round == null && Timer == null)
		{
			Application.Quit ();
			Destroy (Round);
		}
			

		Application.Quit ();
	}
}
