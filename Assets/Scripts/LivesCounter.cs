using UnityEngine;
using System.Collections;

public class LivesCounter : MonoBehaviour {

	int initialLives = 3;
	public int extraLives = 0;
	public int totalLives;
	
	// Update is called once per frame
	void Update () 
	{
	
		totalLives = initialLives + extraLives;

		//lives text

	}
}
