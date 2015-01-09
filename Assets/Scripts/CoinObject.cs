using UnityEngine;
using System.Collections;

public class CoinObject : MonoBehaviour 
{
	private CoinCounter coinCounter;

	void Awake()
	{
		coinCounter = GameObject.Find ("CoinText").GetComponent<CoinCounter> ();
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
			print ("you Got It");


		coinCounter.coinCount++;

		gameObject.SetActive(false);


	}
}
