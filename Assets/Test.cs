using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		print(PlayerPrefs.GetFloat("Player Score"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
