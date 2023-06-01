using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taimers : MonoBehaviour 
{
	float currentTime = 0;
	float startingTime = 10f;

	[SerializeField] Texture TaimersText;
	void Start ()
	{
		currentTime = startingTime;	
	}


	void Update()
	{
		currentTime -= 1 * Time.deltaTime;
		print (currentTime);
	}

}






