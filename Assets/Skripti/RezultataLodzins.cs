using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RezultataLodzins : MonoBehaviour
{
	private int vehiclesPlaced = 0; // Skaits, cik transportlīdzekļi ir novietoti
	private bool gameFinished = false; // Vai spēle ir pabeigta
	private float gameTime = 0f; // Spēles laiks

	private const int TotalVehicles = 12; // Kopējais transportlīdzekļu skaits
	private const float ThreeStarTime = 60f; // Laiks, lai iegūtu visas trīs zvaigznes (1 minūte)
	private const float TwoStarTime = 120f; // Laiks, lai iegūtu divas zvaigznes (2 minūtes)
	private const float MaxGameTime = 150f; // Maksimālais laiks (2.5 minūtes)

	public Image starImage1;
	public Image starImage2;
	public Image starImage3;
	public Button restartButton;
	public Text resultText;
	public Text timerText;

	// Use this for initialization
	void Start()
	{
		restartButton.gameObject.SetActive(false);
	}

	// Update is called once per frame
	void Update()
	{
		if (gameFinished)
			return;

		if (vehiclesPlaced == TotalVehicles) // Pārbaudām, vai visi transportlīdzekļi ir novietoti
		{
			gameFinished = true;
			DisplayResults();
		}
		else
		{
			gameTime += Time.deltaTime; // Palielinām spēles laiku
			UpdateTimerText();

			if (gameTime >= MaxGameTime) // Pārbaudām, vai laiks ir beidzies
			{
				gameFinished = true;
				DisplayResults();
			}
		}
	}

	// Metode, lai parādītu rezultātus
	private void DisplayResults()
	{
		string resultText = "Spēle pabeigta!\n";
		resultText += "Laiks: " + FormatTime(gameTime) + "\n";
		resultText += "Zvaigžņu skaits: " + CalculateStarCount() + "\n";
		resultText += "Vai vēlaties sākt spēli no jauna?";

		this.resultText.text = resultText;
		DisplayStars(CalculateStarCount());
		restartButton.gameObject.SetActive(true);
	}

	// Metode, lai aprēķinātu zvaigžņu skaitu atkarībā no spēles laika
	private int CalculateStarCount()
	{
		if (gameTime <= ThreeStarTime)
			return 3;
		else if (gameTime <= TwoStarTime)
			return 2;
		else
			return 0;
	}

	// Metode, lai formatētu laiku formātā mm:ss
	private string FormatTime(float timeInSeconds)
	{
		TimeSpan timeSpan = TimeSpan.FromSeconds(timeInSeconds);
		return string.Format("{0:00}:{1:00}", timeSpan.Minutes, timeSpan.Seconds);
	}

	// Metode, lai atjauninātu taimera tekstu
	private void UpdateTimerText()
	{
		timerText.text = FormatTime(gameTime);
	}

	// Metode, lai attēlotu atbilstošo zvaigžņu skaitu
	private void DisplayStars(int starCount)
	{
		starImage1.gameObject.SetActive(starCount >= 1);
		starImage2.gameObject.SetActive(starCount >= 2);
		starImage3.gameObject.SetActive(starCount >= 3);
	}

	// Metode, kas tiek izsaukta no restartButton
	public void RestartGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
	}
}
