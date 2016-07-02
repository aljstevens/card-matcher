using UnityEngine;
using System.Collections;

public class ShowButtons : MonoBehaviour {

	public GameObject LastOptions;
	public GameObject NewOptions;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		LastOptions.SetActive (false);
		NewOptions.SetActive (true);
	}
}
