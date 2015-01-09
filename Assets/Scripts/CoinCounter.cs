using UnityEngine;
using System.Collections;
[ExecuteInEditMode]

public class CoinCounter : MonoBehaviour {


	public int coinCount = 0;

	// Update is called once per frame
	void Update () 
	{

		guiText.text = "x" + coinCount;
	
	}
}
