using UnityEngine;
using System.Collections;

public class ButtonSpawnerTimeAttack : MonoBehaviour {

	public float ButtonLoadTime =2f;
	public GameObject ButtonsFirst;
	public GameObject ButtonsSecond;
	public GameObject LastTimer;

	// Use this for initialization
	void Awake ()
	{
		LastTimer = GameObject.FindWithTag ("LastTimer");
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		ButtonLoadTime -= Time.deltaTime;

		if (ButtonLoadTime <= 0 && LastTimer == null )
		{
			ButtonsFirst.SetActive (true);
			Destroy (gameObject);
		}

		if (ButtonLoadTime <= 0 && LastTimer != null )
		{
			ButtonsSecond.SetActive (true);
			Destroy (gameObject);
		}
	}
}
