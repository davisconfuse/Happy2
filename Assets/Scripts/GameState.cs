using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour 
{
	private GameObject[] coins;
	public int totalCoins;
	private CoinCounter coinCounter;
	private LivesCounter livesCounter;

	// Use this for initialization
	void Awake () 
	{
		coinCounter = GameObject.Find ("CoinText").GetComponent<CoinCounter>();
		livesCounter = GameObject.Find ("LivesText").GetComponent<LivesCounter>();

		coins = GameObject.FindGameObjectsWithTag("Coin");
		totalCoins = coins.Length;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Get an extra life if all coins are collected
		int collectedCoins;
		collectedCoins = coinCounter.coinCount;

		livesCounter.extraLives = collectedCoins / totalCoins;
		if(livesCounter.totalLives < 0)
		{
			print("GAME OVER!");
		}


	
	}
}
