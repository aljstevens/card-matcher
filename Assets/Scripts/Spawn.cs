using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject CardClubs;
	public GameObject CardDiamonds;
	public GameObject CardHearts;
	public GameObject CardSpades;

	private float Chance;

	// Use this for initialization
	void Start ()
	{
		Chance = Random.Range (1, 5);

		if (Chance == 1) 
		{
			Instantiate (CardClubs, transform.position, transform.rotation);
			Destroy (gameObject);
		}

		if (Chance == 2) 
		{
			Instantiate (CardDiamonds, transform.position, transform.rotation);
			Destroy (gameObject);
		}

		if (Chance == 3) 
		{
			Instantiate (CardHearts, transform.position, transform.rotation);
			Destroy (gameObject);
		}

		if (Chance == 4) 
		{
			Instantiate (CardSpades, transform.position, transform.rotation);
			Destroy (gameObject);
		}

		if (Chance == 5) 
		{
			Chance = Random.Range (1, 5);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
