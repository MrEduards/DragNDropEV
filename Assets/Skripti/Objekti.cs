using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
 //Uzglabā visus velkamos objektus
 public GameObject atkritumuMasina;
 public GameObject atraPalidziba;
 public GameObject autobuss;

 //Uzglabā katra transportlīdzekļa sākotnējo atrašanās vietu
 [HideInInspector]
 public Vector2 atkrMKoord;
 [HideInInspector]
 public Vector2 atkrPKoord;

  [HideInInspector]
 public Vector2 bussKoord;

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

		atkrPKoord = 
		atraPalidziba.GetComponent<RectTransform>().localPosition;

		bussKoord = 
		autobuss.GetComponent<RectTransform>().localPosition;
	}
	
	
}
