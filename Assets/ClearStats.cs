using UnityEngine;
using System.Collections;

public class ClearStats : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		PlayerPrefs.SetFloat ("HighestRound", 0);
		PlayerPrefs.SetFloat ("AI Draw", 0);
		PlayerPrefs.SetFloat ("AI Win", 0);
		PlayerPrefs.SetFloat ("AI Loss", 0);
		PlayerPrefs.SetFloat ("Quick Loss", 0);
		PlayerPrefs.SetFloat ("Match Win", 0);
		gameObject.SetActive (false);

	}
}
