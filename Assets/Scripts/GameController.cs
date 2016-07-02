using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject Spot1;
	public GameObject Spot2;
	public GameObject Spot3;
	public GameObject Spot4;
	public GameObject Spot5;
	public GameObject Spot6;
	public GameObject Spot7;
	public GameObject Spot8;
	public GameObject Spot9;
	public GameObject Spot10;
	public GameObject Spot11;
	public GameObject Spot12;
	public GameObject Spot13;
	public GameObject Spot14;
	public GameObject Spot15;
	public GameObject Spot16;

	public GameObject Card1;
	public GameObject Card2;
	public GameObject Card3;
	public GameObject Card4;
	public GameObject Card5;
	public GameObject Card6;
	public GameObject Card7;
	public GameObject Card8;

	public GameObject Card1b;
	public GameObject Card2b;
	public GameObject Card3b;
	public GameObject Card4b;
	public GameObject Card5b;
	public GameObject Card6b;
	public GameObject Card7b;
	public GameObject Card8b;



	private float CardPlacing;


	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (CardPlacing == 17) 
		{
			CardPlacing = Random.Range (1, 17);
		}
			
		if (Spot1 != null)
		{
			Debug.Log ("Spawn1");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 !=null)	
			{
				Instantiate (Card1, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 !=null)	
			{
				Instantiate (Card2, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 !=null)	
			{
				Instantiate (Card3, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 !=null)	
			{
				Instantiate (Card4, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 !=null)	
			{
				Instantiate (Card5, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 !=null)	
			{
				Instantiate (Card6, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 !=null)	
			{
				Instantiate (Card7, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 !=null)	
			{
				Instantiate (Card8, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b !=null)	
			{
				Instantiate (Card1b, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b !=null)	
			{
				Instantiate (Card2b, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b !=null)	
			{
				Instantiate (Card3b, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b !=null)	
			{
				Instantiate (Card4b, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b !=null)	
			{
				Instantiate (Card5b, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b !=null)	
			{
				Instantiate (Card6b, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b !=null)	
			{
				Instantiate (Card7b, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b !=null)	
			{
				Instantiate (Card8b, Spot1.transform.position, Spot1.transform.rotation);
				Destroy (Spot1);
				Spot1 = null;
				Card8b = null;
			}
				
		}

		if (Spot2 != null)
		{
			Debug.Log ("Spawn2");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 !=null)	
			{
				Instantiate (Card1, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 !=null)	
			{
				Instantiate (Card2, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 !=null)	
			{
				Instantiate (Card3, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 !=null)	
			{
				Instantiate (Card4, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 !=null)	
			{
				Instantiate (Card5, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 !=null)	
			{
				Instantiate (Card6, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 !=null)	
			{
				Instantiate (Card7, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 !=null)	
			{
				Instantiate (Card8, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b !=null)	
			{
				Instantiate (Card1b, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b !=null)	
			{
				Instantiate (Card2b, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b !=null)	
			{
				Instantiate (Card3b, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b !=null)	
			{
				Instantiate (Card4b, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b !=null)	
			{
				Instantiate (Card5b, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b !=null)	
			{
				Instantiate (Card6b, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b !=null)	
			{
				Instantiate (Card7b, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b !=null)	
			{
				Instantiate (Card8b, Spot2.transform.position, Spot2.transform.rotation);
				Destroy (Spot2);
				Spot2 = null;
				Card8b = null;
			}

		}


		if (Spot3 != null)
		{
			Debug.Log ("Spawn3");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 !=null)	
			{
				Instantiate (Card1, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 !=null)	
			{
				Instantiate (Card2, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 !=null)	
			{
				Instantiate (Card3, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 !=null)	
			{
				Instantiate (Card4, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 !=null)	
			{
				Instantiate (Card5, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 !=null)	
			{
				Instantiate (Card6, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 !=null)	
			{
				Instantiate (Card7, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 !=null)	
			{
				Instantiate (Card8, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b !=null)	
			{
				Instantiate (Card1b, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b !=null)	
			{
				Instantiate (Card2b, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b !=null)	
			{
				Instantiate (Card3b, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b !=null)	
			{
				Instantiate (Card4b, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b !=null)	
			{
				Instantiate (Card5b, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b !=null)	
			{
				Instantiate (Card6b, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b !=null)	
			{
				Instantiate (Card7b, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b !=null)	
			{
				Instantiate (Card8b, Spot3.transform.position, Spot3.transform.rotation);
				Destroy (Spot3);
				Spot3 = null;
				Card8b = null;
			}

		}


		if (Spot4 != null)
		{
			Debug.Log ("Spawn4");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 !=null)	
			{
				Instantiate (Card1, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 !=null)	
			{
				Instantiate (Card2, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 !=null)	
			{
				Instantiate (Card3, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 !=null)	
			{
				Instantiate (Card4, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 !=null)	
			{
				Instantiate (Card5, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 !=null)	
			{
				Instantiate (Card6, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 !=null)	
			{
				Instantiate (Card7, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 !=null)	
			{
				Instantiate (Card8, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b !=null)	
			{
				Instantiate (Card1b, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b !=null)	
			{
				Instantiate (Card2b, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b !=null)	
			{
				Instantiate (Card3b, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b !=null)	
			{
				Instantiate (Card4b, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b !=null)	
			{
				Instantiate (Card5b, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b !=null)	
			{
				Instantiate (Card6b, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b !=null)	
			{
				Instantiate (Card7b, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b !=null)	
			{
				Instantiate (Card8b, Spot4.transform.position, Spot4.transform.rotation);
				Destroy (Spot4);
				Spot4 = null;
				Card8b = null;
			}


		}

		if (Spot5 != null)
		{
			Debug.Log ("Spawn5");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 !=null)	
			{
				Instantiate (Card1, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 !=null)	
			{
				Instantiate (Card2, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 !=null)	
			{
				Instantiate (Card3, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 !=null)	
			{
				Instantiate (Card4, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 !=null)	
			{
				Instantiate (Card5, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 !=null)	
			{
				Instantiate (Card6, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 !=null)	
			{
				Instantiate (Card7, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 !=null)	
			{
				Instantiate (Card8, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b !=null)	
			{
				Instantiate (Card1b, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b !=null)	
			{
				Instantiate (Card2b, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b !=null)	
			{
				Instantiate (Card3b, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b !=null)	
			{
				Instantiate (Card4b, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b !=null)	
			{
				Instantiate (Card5b, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b !=null)	
			{
				Instantiate (Card6b, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b !=null)	
			{
				Instantiate (Card7b, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b !=null)	
			{
				Instantiate (Card8b, Spot5.transform.position, Spot5.transform.rotation);
				Destroy (Spot5);
				Spot5 = null;
				Card8b = null;
			}

		}

		if (Spot6 != null)
		{
			Debug.Log ("Spawn6");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 !=null)	
			{
				Instantiate (Card1, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 !=null)	
			{
				Instantiate (Card2, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 !=null)	
			{
				Instantiate (Card3, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 !=null)	
			{
				Instantiate (Card4, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 !=null)	
			{
				Instantiate (Card5, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 !=null)	
			{
				Instantiate (Card6, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 !=null)	
			{
				Instantiate (Card7, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 !=null)	
			{
				Instantiate (Card8, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b !=null)	
			{
				Instantiate (Card1b, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b !=null)	
			{
				Instantiate (Card2b, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b !=null)	
			{
				Instantiate (Card3b, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b !=null)	
			{
				Instantiate (Card4b, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b !=null)	
			{
				Instantiate (Card5b, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b !=null)	
			{
				Instantiate (Card6b, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b !=null)	
			{
				Instantiate (Card7b, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b !=null)	
			{
				Instantiate (Card8b, Spot6.transform.position, Spot6.transform.rotation);
				Destroy (Spot6);
				Spot6 = null;
				Card8b = null;
			}

		}

		if (Spot7 != null)
		{
			Debug.Log ("Spawn7");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 !=null)	
			{
				Instantiate (Card1, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 !=null)	
			{
				Instantiate (Card2, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 !=null)	
			{
				Instantiate (Card3, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 !=null)	
			{
				Instantiate (Card4, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 !=null)	
			{
				Instantiate (Card5, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 !=null)	
			{
				Instantiate (Card6, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 !=null)	
			{
				Instantiate (Card7, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 !=null)	
			{
				Instantiate (Card8, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b !=null)	
			{
				Instantiate (Card1b, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b !=null)	
			{
				Instantiate (Card2b, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b !=null)	
			{
				Instantiate (Card3b, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b !=null)	
			{
				Instantiate (Card4b, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b !=null)	
			{
				Instantiate (Card5b, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b !=null)	
			{
				Instantiate (Card6b, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b !=null)	
			{
				Instantiate (Card7b, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b !=null)	
			{
				Instantiate (Card8b, Spot7.transform.position, Spot7.transform.rotation);
				Destroy (Spot7);
				Spot7 = null;
				Card8b = null;
			}

		}

		if (Spot8 != null)
		{
			Debug.Log ("Spawn8");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 != null) 
			{
				Instantiate (Card1, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 != null) {
				Instantiate (Card2, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 != null) {
				Instantiate (Card3, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 != null) 
			{
				Instantiate (Card4, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 != null) {
				Instantiate (Card5, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 != null) {
				Instantiate (Card6, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 != null) {
				Instantiate (Card7, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 != null) {
				Instantiate (Card8, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b != null) {
				Instantiate (Card1b, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b != null) {
				Instantiate (Card2b, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b != null) {
				Instantiate (Card3b, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b != null) {
				Instantiate (Card4b, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b != null) {
				Instantiate (Card5b, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b != null) {
				Instantiate (Card6b, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b != null) {
				Instantiate (Card7b, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b != null)
			{
				Instantiate (Card8b, Spot8.transform.position, Spot8.transform.rotation);
				Destroy (Spot8);
				Spot8 = null;
				Card8b = null;
			}
		}
			if (Spot9 != null)
			{
			Debug.Log ("Spawn9");
				CardPlacing = Random.Range (1, 17);

				if (CardPlacing == 1 && Card1 !=null)	
				{
					Instantiate (Card1, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card1 = null;
				}

				if (CardPlacing == 2 && Card2 !=null)	
				{
					Instantiate (Card2, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card2 = null;
				}

				if (CardPlacing == 3 && Card3 !=null)	
				{
					Instantiate (Card3, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card3 = null;
				}

				if (CardPlacing == 4 && Card4 !=null)	
				{
					Instantiate (Card4, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card4 = null;
				}

				if (CardPlacing == 5 && Card5 !=null)	
				{
					Instantiate (Card5, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card5 = null;
				}

				if (CardPlacing == 6 && Card6 !=null)	
				{
					Instantiate (Card6, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card6 = null;
				}

				if (CardPlacing == 7 && Card7 !=null)	
				{
					Instantiate (Card7, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card7 = null;
				}

				if (CardPlacing == 8 && Card8 !=null)	
				{
					Instantiate (Card8, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card8 = null;
				}

				if (CardPlacing == 9 && Card1b !=null)	
				{
					Instantiate (Card1b, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card1b = null;
				}

				if (CardPlacing == 10 && Card2b !=null)	
				{
					Instantiate (Card2b, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card2b = null;
				}

				if (CardPlacing == 11 && Card3b !=null)	
				{
					Instantiate (Card3b, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card3b = null;
				}

				if (CardPlacing == 12 && Card4b !=null)	
				{
					Instantiate (Card4b, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card4b = null;
				}

				if (CardPlacing == 13 && Card5b !=null)	
				{
					Instantiate (Card5b, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card5b = null;
				}

				if (CardPlacing == 14 && Card6b !=null)	
				{
					Instantiate (Card6b, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card6b = null;
				}

				if (CardPlacing == 15 && Card7b !=null)	
				{
					Instantiate (Card7b, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card7b = null;
				}

				if (CardPlacing == 16 && Card8b !=null)	
				{
					Instantiate (Card8b, Spot9.transform.position, Spot9.transform.rotation);
					Destroy (Spot9);
					Spot9 = null;
					Card8b = null;
				}
		}

		if (Spot10 != null)
		{
			Debug.Log ("Spawn10");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 != null) {
				Instantiate (Card1, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 != null) {
				Instantiate (Card2, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 != null) {
				Instantiate (Card3, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 != null) 
			{
				Instantiate (Card4, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 != null) {
				Instantiate (Card5, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 != null) 
			{
				Instantiate (Card6, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 != null) {
				Instantiate (Card7, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 != null) {
				Instantiate (Card8, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b != null) {
				Instantiate (Card1b, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b != null) {
				Instantiate (Card2b, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b != null) {
				Instantiate (Card3b, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b != null) {
				Instantiate (Card4b, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b != null) {
				Instantiate (Card5b, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b != null) {
				Instantiate (Card6b, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b != null) {
				Instantiate (Card7b, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b != null) 
			{	
				Instantiate (Card8b, Spot10.transform.position, Spot10.transform.rotation);
				Destroy (Spot10);
				Spot10 = null;
				Card8b = null;
			}
		}
		if (Spot11 != null)
		{
			Debug.Log ("Spawn11");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 != null) {
				Instantiate (Card1, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 != null) {
				Instantiate (Card2, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 != null) {
				Instantiate (Card3, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 != null) 
			{
				Instantiate (Card4, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 != null) {
				Instantiate (Card5, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 != null) {
				Instantiate (Card6, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 != null) {
				Instantiate (Card7, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 != null) {
				Instantiate (Card8, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b != null) {
				Instantiate (Card1b, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b != null) {
				Instantiate (Card2b, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b != null) {
				Instantiate (Card3b, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b != null) {
				Instantiate (Card4b, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b != null) {
				Instantiate (Card5b, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b != null) {
				Instantiate (Card6b, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b != null) {
				Instantiate (Card7b, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b != null) 
			{	
				Instantiate (Card8b, Spot11.transform.position, Spot11.transform.rotation);
				Destroy (Spot11);
				Spot11 = null;
				Card8b = null;
			}
		}

		if (Spot12 != null)
		{
			Debug.Log ("Spawn12");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 != null) {
				Instantiate (Card1, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 != null) {
				Instantiate (Card2, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 != null) {
				Instantiate (Card3, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 != null) {
				Instantiate (Card4, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 != null) {
				Instantiate (Card5, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 != null) {
				Instantiate (Card6, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 != null) {
				Instantiate (Card7, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 != null) {
				Instantiate (Card8, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b != null) {
				Instantiate (Card1b, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b != null) {
				Instantiate (Card2b, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b != null) {
				Instantiate (Card3b, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b != null) {
				Instantiate (Card4b, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b != null) {
				Instantiate (Card5b, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b != null) {
				Instantiate (Card6b, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b != null) {
				Instantiate (Card7b, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b != null) 
			{	
				Instantiate (Card8b, Spot12.transform.position, Spot12.transform.rotation);
				Destroy (Spot12);
				Spot12 = null;
				Card8b = null;
			}
		}
		if (Spot13 != null)
		{
			Debug.Log ("Spawn13");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 != null) {
				Instantiate (Card1, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 != null) {
				Instantiate (Card2, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 != null) {
				Instantiate (Card3, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 != null) {
				Instantiate (Card4, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 != null) {
				Instantiate (Card5, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 != null) {
				Instantiate (Card6, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 != null) {
				Instantiate (Card7, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 != null) {
				Instantiate (Card8, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b != null) {
				Instantiate (Card1b, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b != null) {
				Instantiate (Card2b, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b != null) {
				Instantiate (Card3b, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b != null) {
				Instantiate (Card4b, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b != null) {
				Instantiate (Card5b, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b != null) {
				Instantiate (Card6b, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b != null) {
				Instantiate (Card7b, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b != null) 
			{	
				Instantiate (Card8b, Spot13.transform.position, Spot13.transform.rotation);
				Destroy (Spot13);
				Spot13 = null;
				Card8b = null;
			}
		}

		if (Spot14 != null)
		{
			Debug.Log ("Spawn14");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 != null) {
				Instantiate (Card1, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 != null) {
				Instantiate (Card2, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 != null) {
				Instantiate (Card3, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 != null) 
			{
				Instantiate (Card4, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 != null) {
				Instantiate (Card5, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 != null) {
				Instantiate (Card6, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 != null) {
				Instantiate (Card7, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 != null) {
				Instantiate (Card8, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b != null) {
				Instantiate (Card1b, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b != null) {
				Instantiate (Card2b, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b != null) {
				Instantiate (Card3b, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b != null) {
				Instantiate (Card4b, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b != null) {
				Instantiate (Card5b, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b != null) {
				Instantiate (Card6b, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b != null) {
				Instantiate (Card7b, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b != null) 
			{	
				Instantiate (Card8b, Spot14.transform.position, Spot14.transform.rotation);
				Destroy (Spot14);
				Spot14 = null;
				Card8b = null;
			}
		}

		if (Spot15 != null)
		{
			Debug.Log ("Spawn15");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 != null) {
				Instantiate (Card1, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 != null) {
				Instantiate (Card2, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 != null) {
				Instantiate (Card3, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 != null)
			{
				Instantiate (Card4, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 != null) {
				Instantiate (Card5, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 != null) {
				Instantiate (Card6, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 != null) {
				Instantiate (Card7, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 != null) {
				Instantiate (Card8, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b != null) 
			{
				Instantiate (Card1b, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b != null) {
				Instantiate (Card2b, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b != null) {
				Instantiate (Card3b, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b != null) {
				Instantiate (Card4b, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b != null) {
				Instantiate (Card5b, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b != null) {
				Instantiate (Card6b, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b != null) {
				Instantiate (Card7b, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b != null) 
			{	
				Instantiate (Card8b, Spot15.transform.position, Spot15.transform.rotation);
				Destroy (Spot15);
				Spot15 = null;
				Card8b = null;
			}
		}

		if (Spot16 != null)
		{
			Debug.Log ("Spawn16");
			CardPlacing = Random.Range (1, 17);

			if (CardPlacing == 1 && Card1 != null) {
				Instantiate (Card1, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card1 = null;
			}

			if (CardPlacing == 2 && Card2 != null) {
				Instantiate (Card2, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card2 = null;
			}

			if (CardPlacing == 3 && Card3 != null) {
				Instantiate (Card3, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card3 = null;
			}

			if (CardPlacing == 4 && Card4 != null)
			{
				Instantiate (Card4, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card4 = null;
			}

			if (CardPlacing == 5 && Card5 != null) {
				Instantiate (Card5, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card5 = null;
			}

			if (CardPlacing == 6 && Card6 != null) {
				Instantiate (Card6, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card6 = null;
			}

			if (CardPlacing == 7 && Card7 != null) {
				Instantiate (Card7, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card7 = null;
			}

			if (CardPlacing == 8 && Card8 != null) {
				Instantiate (Card8, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card8 = null;
			}

			if (CardPlacing == 9 && Card1b != null)
			{
				Instantiate (Card1b, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card1b = null;
			}

			if (CardPlacing == 10 && Card2b != null) {
				Instantiate (Card2b, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card2b = null;
			}

			if (CardPlacing == 11 && Card3b != null) {
				Instantiate (Card3b, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card3b = null;
			}

			if (CardPlacing == 12 && Card4b != null) {
				Instantiate (Card4b, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card4b = null;
			}

			if (CardPlacing == 13 && Card5b != null) {
				Instantiate (Card5b, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card5b = null;
			}

			if (CardPlacing == 14 && Card6b != null) {
				Instantiate (Card6b, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card6b = null;
			}

			if (CardPlacing == 15 && Card7b != null) {
				Instantiate (Card7b, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card7b = null;
			}

			if (CardPlacing == 16 && Card8b != null) 
			{	
				Instantiate (Card8b, Spot16.transform.position, Spot16.transform.rotation);
				Destroy (Spot16);
				Spot16 = null;
				Card8b = null;
			}
		}


		}
}
