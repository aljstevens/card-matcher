using UnityEngine;
using System.Collections;

public class TimeAttackRound : MonoBehaviour {

	public GameObject Buttons;
	public GameObject GM;

	private Timer time;

	// Use this for initialization
	void Awake () 
	{
		//time = TimerObject.GetComponent <Timer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		GM.SetActive (true);
		Destroy (Buttons);
	}
}
