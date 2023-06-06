using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkanasEffekti : MonoBehaviour
{
	public AudioClip[] dziesmuSaraksts;
	public GameObject[] objektuSaraksts;
	public Vector3[] vietuSaraksts;
	public float[] lielumaSaraksts;

	private bool[] objektuIevilkts;

	private AudioSource audioAvots;

	void Start()
	{
		audioAvots = GetComponent<AudioSource>();

		// Inicializējam objektu ievilkšanas statusu
		objektuIevilkts = new bool[objektuSaraksts.Length];
	}

	void Update()
	{
		// Pārbaudām katru objektu
		for (int i = 0; i < objektuSaraksts.Length; i++)
		{
			GameObject objekts = objektuSaraksts[i];
			Vector3 vieta = vietuSaraksts[i];
			float lielums = lielumaSaraksts[i];

			// Pārbaudām, vai objekts ir ievilkts atbilstošajā vietā ar attiecīgo izmēru
			if (!objektuIevilkts[i] && objekts.transform.position == vieta && objekts.transform.localScale.x >= lielums)
			{
				objektuIevilkts[i] = true;
				AtskaņotDziesmu(i);
			}
		}
	}

	void AtskaņotDziesmu(int indekss)
	{
		if (indekss >= 0 && indekss < dziesmuSaraksts.Length)
		{
			AudioClip dziesma = dziesmuSaraksts[indekss];
			audioAvots.clip = dziesma;
			audioAvots.Play();
		}
	}
}


