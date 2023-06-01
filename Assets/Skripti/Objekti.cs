using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
 //Uzglabā visus velkamos objektus
 public GameObject atkritumuMasina;
 public GameObject atraPalidziba;
 public GameObject autobuss;
 public GameObject b2;
 public GameObject cementMasina;
 public GameObject e46;

 //Uzglabā katra transportlīdzekļa sākotnējo atrašanās vietu
 [HideInInspector]
 public Vector2 atkrMKoord;
 [HideInInspector]
 public Vector2 atrPKoord;

  [HideInInspector]
 public Vector2 bussKoord;

	[HideInInspector]
	public Vector2 b2Koord;

	[HideInInspector]
	public Vector2 buvMasinaKoord;

	[HideInInspector]
	public Vector2 e46Koord;



 public Canvas kanva;

 //Uzglabās audio avotu, kurā atskaņot audio efektus
 public AudioSource skanasAvots;
 //Uzglabā audio failus
 public AudioClip[] skanaKoAtskanot;

 [HideInInspector]
 public bool vaiIstajaVieta = false;
	public GameObject pedejaisVilktais = null;


	// Use this for initialization
	void Start () {
		//Uzsākot spēli piefiksē kur sākotnēji atrodas katra mašīna
		atkrMKoord = 
		atkritumuMasina.GetComponent<RectTransform>().localPosition;

		atrPKoord = 
		atraPalidziba.GetComponent<RectTransform>().localPosition;

		bussKoord = 
		autobuss.GetComponent<RectTransform>().localPosition;

		b2Koord =
			b2.GetComponent<RectTransform> ().localPosition;

		buvMasinaKoord =
			cementMasina.GetComponent<RectTransform> ().localPosition;

		e46Koord =
			e46.GetComponent<RectTransform> ().localPosition;
	}
	
	
}
