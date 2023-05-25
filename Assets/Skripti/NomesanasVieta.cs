using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class NomesanasVieta : MonoBehaviour, IDropHandler {
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yizmeruStarp;
	public Objekti objektuSkipts;

	public void OnDrop(PointerEventData eventData)
	{
		if (eventData.pointerDrag != null) {
			if (eventData.pointerDrag.tag.Equals (tag)) {
				velkObjZRot = eventData.pointerDrag.GetComponent<RectTransform> ().transform.eulerAngles.z;

				vietasZRot = GetComponent<RectTransform> ().transform.eulerAngles.z;
				rotacijasStarpiba = Mathf.Abs (vietasZRot - velkObjIzm.x);

				velkObjIzm = eventData.pointerDrag.GetComponent<RectTransform> ().localScale;

				vietasIzm = GetComponent<RectTransform> ().localScale;

				xIzmeruStarp = Mathf.Abs (vietasIzm.x - velkObjIzm.x);
				yizmeruStarp = Mathf.Abs (vietasIzm.y - velkObjIzm.y);

				Debug.Log ("Rotācijs starpība: " + rotacijasStarpiba
				+ "\nx starpība: " + xIzmeruStarp
				+ "\ny starpība: " + yizmeruStarp);

				if ((rotacijasStarpiba <= 6 ||
				    (rotacijasStarpiba >= 345 && rotacijasStarpiba <= 360)) &&
				    (xIzmeruStarp <= 0.1 && yizmeruStarp <= 0.1)) {
					Debug.Log ("Nolikts pareizā vietā!");
					objektuSkipts.vaiIstajaVieta = true;
					eventData.pointerDrag.GetComponent<RectTransform> ().anchoredPosition = 
						GetComponent<RectTransform> ().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform> ().localRotation = 
						GetComponent<RectTransform> ().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform> ().localScale = 
						GetComponent<RectTransform> ().localScale;


					switch (eventData.pointerDrag.tag) {
					case "atkritumi":
						objektuSkipts.skanasAvots.
						PlayOneShot (objektuSkipts.skanaKoAtskanot [1]);
						break;
					case "medicina":
						objektuSkipts.skanasAvots.
						PlayOneShot (objektuSkipts.skanaKoAtskanot [2]);
						break;
					case "buss":
						objektuSkipts.skanasAvots.
						PlayOneShot (objektuSkipts.skanaKoAtskanot [3]);
						break;
					case "b2":
						objektuSkipts.skanasAvots.
						PlayOneShot (objektuSkipts.skanaKoAtskanot [4]);
						break;

					case "buvMasina":
						objektuSkipts.skanasAvots.
						PlayOneShot (objektuSkipts.skanaKoAtskanot [5]);
						break;
					
					default:
						Debug.Log ("Tags netiek atpazīts!");
						break;
					}
				}

			} else {
				objektuSkipts.vaiIstajaVieta = false;
				objektuSkipts.skanasAvots.PlayOneShot (objektuSkipts.skanaKoAtskanot [0]);
				switch (eventData.pointerDrag.tag) {
				case "atkritumi":
					objektuSkipts.atkritumuMasina.GetComponent<RectTransform> ().localPosition =
						objektuSkipts.atkrMKoord;
					break;
				case "medicina":
					objektuSkipts.atraPalidziba.GetComponent<RectTransform> ().localPosition = objektuSkipts.atrPKoord;
					break;
				case "buss":
					objektuSkipts.autobuss.GetComponent<RectTransform> ().localPosition =
						objektuSkipts.bussKoord;
					break;

				case "b2":
					objektuSkipts.b2.GetComponent<RectTransform> ().localPosition =
						objektuSkipts.b2Koord;
					break;

				case "buvMasina":
					objektuSkipts.cementMasina.GetComponent<RectTransform> ().localPosition =
						objektuSkipts.buvMasinaKoord;
					break;

			

				default:
					Debug.Log ("Tags netiek atpazīts!");
					break;
				}
			
			}
		}
	}
}
	


