using UnityEngine;
using System.Collections;

public class VsMode : MonoBehaviour {

	public GameObject Buttons;
	public GameObject TimerObject;
	public GameObject TimerImage;
	public GameObject GM;
	public GameObject AI;
	public bool Easy;
	public bool Normal;
	public bool Hard;
	public bool Player1;

	private AIScript aiscript;
	private Timer time;

	// Use this for initialization
	void Awake () 
	{
		AI.SetActive (true);
		aiscript = AI.GetComponent<AIScript> ();
		//time = TimerObject.GetComponent <Timer> ();

		if (Easy == true) 
		{
			aiscript.IsEasy = true;
		}

		if (Normal == true) 
		{
			aiscript.IsNormal = true;
		}

		if (Hard == true) 
		{
			aiscript.IsHard = true;
		}

		if (Player1 == true) 
		{
			aiscript.IsPlayer1 = true;
			aiscript.IsPlayer2 = false;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		GM.SetActive (true);
		Destroy (Buttons);
		Destroy (TimerObject);
		Destroy (TimerImage);
	}
}
