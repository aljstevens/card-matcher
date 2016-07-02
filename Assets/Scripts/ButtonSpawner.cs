using UnityEngine;
using System.Collections;

public class ButtonSpawner : MonoBehaviour {

	public float ButtonLoadTime =2f;
	public GameObject Buttons;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		ButtonLoadTime -= Time.deltaTime;

		if (ButtonLoadTime <= 0)
		{
			Buttons.SetActive (true);
			Destroy (gameObject);
		}
	}
}
