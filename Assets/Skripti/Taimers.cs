using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Taimers : MonoBehaviour
{
	float currentTime = 0;
	float startingTime = 180f; // 3 minūtes

	[SerializeField] Text taimeraTeksts;

	void Start()
	{
		currentTime = startingTime;
	}

	void Update()
	{
		currentTime -= Time.deltaTime;
		PārvaldītLaiku();
		AtjauninātTaimeraTekstu();
	}

	void PārvaldītLaiku()
	{
		if (currentTime <= 0)
		{
			currentTime = 0;
			// Šeit vari ievietot kodu, kas izpildās, kad taimers sasniedz 0
		}
	}

	void AtjauninātTaimeraTekstu()
	{
		int min = Mathf.FloorToInt(currentTime / 60);
		int sekundes = Mathf.FloorToInt(currentTime % 60);
		string formatētsLaiks = string.Format("{0:00}:{1:00}", min, sekundes);
		taimeraTeksts.text = formatētsLaiks;
	}
}
