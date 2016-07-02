using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class List : MonoBehaviour {

	public int Card1 =2;
	public int Card2 =3;
	public int Card3;
	public int Card4;

	List<int> CardPicker;

	// This will make a list of all cards
	void MakeList()
	{
		CardPicker = new List<int>();
		for (int i = 1; i <= 16; ++i)
		{
			CardPicker.Add(i);
			CardPicker.Add(Card1);
			CardPicker.Add(Card2);
			CardPicker.Add(3);
			CardPicker.Add(4);
		}
	}

	// This will return a random card that hasn't been used yet
	int RandomCard()
	{
		// Return a bad card if the list wasn't made yet
		if (CardPicker == null) return -1;

		// Return a bad card if the list is already empty
		if (CardPicker.Count <= 0) return -1;

		// Return a random card that's left and remove it so we don't pick it again
		int PickedCardIndex = Random.Range(0, CardPicker.Count);
		int PickedCard = CardPicker[PickedCardIndex];
		CardPicker.RemoveAt(PickedCardIndex);
		return PickedCard;
	}

	void Update ()
	{
		Card1 = RandomCard ();
		Card2 = RandomCard ();
		Card3 = RandomCard ();
		Card4 = RandomCard ();
	}
}
