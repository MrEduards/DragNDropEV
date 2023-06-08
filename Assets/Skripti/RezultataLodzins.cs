using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class RezultataLodzins : MonoBehaviour

{
	public Text winMessageText;
	public GameObject UzvarasLogs;
	public Text timeText;
	public Image star1;
	public Image star2;
	public Image star3;
	public Button restartButton;

	public int Skait;


	private float startTime;
	private float endTime;
	private int starsEarned;



	 void Start()

	{
		Skait = 0;


		UzvarasLogs.SetActive (false);

		winMessageText.gameObject.SetActive(false);

		star1.gameObject.SetActive(false);

		star2.gameObject.SetActive(false);

		star3.gameObject.SetActive(false);

		restartButton.gameObject.SetActive(false);

		startTime = Time.time;

	}



	 void Update()
	{
		if (Skait == 11) {
			UzvarasLogs.SetActive (true);

			winMessageText.gameObject.SetActive(true);

			star1.gameObject.SetActive(true);

			star2.gameObject.SetActive(true);

			star3.gameObject.SetActive(true);

			restartButton.gameObject.SetActive(true);
		
		
		
		}
	
	}
	 void UpdateTimer()
	{
		float elapsedTime = Time.time - startTime;
		int minutes = (int)(elapsedTime / 60);
		int seconds = (int)(elapsedTime % 60);
		timeText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
	}


	 void CalculateStarsEarned()

	{

		float elapsedTime = endTime - startTime;

		if (elapsedTime <= 60f)

		{

			starsEarned = 3;

		}

		else if (elapsedTime <= 120f)

		{

			starsEarned = 2;

		}

		else if (elapsedTime <= 150f)

		{

			starsEarned = 1;

		}

		else

		{

			starsEarned = 0;

		}

	}



	 void ShowWinMessage()
	{
		winMessageText.gameObject.SetActive(true);
		winMessageText.text = "Uzvara!";

	}



	 void ShowStarsEarned()

	{

		switch (starsEarned)

		{

		case 1:

			star1.gameObject.SetActive(true);

			break;

		case 2:

			star1.gameObject.SetActive(true);

			star2.gameObject.SetActive(true);

			break;

		case 3:

			star1.gameObject.SetActive(true);

			star2.gameObject.SetActive(true);

			star3.gameObject.SetActive(true);

			break;

		}
	}

	public void RestartGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
	}
}
	
