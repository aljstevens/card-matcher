using UnityEngine;
using System.Collections;

public class TimedPlays : MonoBehaviour {
	public GameObject Buttons;
	public GameObject TimerObject;
	public GameObject TimerImage;
	public float TimeAmount;
	public GameObject GM;

	private Timer time;

	// Use this for initialization
	void Awake () 
	{
		time = TimerObject.GetComponent <Timer> ();
	}
	// Update is called once per frame
	void Update ()
	{
		time.secondstext = TimeAmount;
		time.Seconds = TimeAmount;
		Destroy (Buttons);
		TimerObject.SetActive (true);
		TimerImage.SetActive (true);
		GM.SetActive (true);
		Destroy (gameObject);
	}
}
