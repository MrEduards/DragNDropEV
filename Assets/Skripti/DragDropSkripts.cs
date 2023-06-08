using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Jāiemportē, lai varētu lietot
// visus I interfeisus
using UnityEngine.EventSystems;
public class DragDropSkripts : MonoBehaviour, IBeginDragHandler,
IDragHandler, IEndDragHandler {
 //Uzglabā norādi uz Objekti skriptu
 public Objekti objektuSkripts;
 private CanvasGroup kanvasGrupa;
 private RectTransform velkObjRectTransf;
	public RezultataLodzins skaita; 

 public void OnBeginDrag(PointerEventData eventData)
 { 
	objektuSkripts.pedejaisVilktais = null;
	kanvasGrupa.alpha = 0.6f;
	kanvasGrupa.blocksRaycasts = false;
 }

 public void OnDrag(PointerEventData eventData)
 {
		velkObjRectTransf.anchoredPosition +=
			eventData.delta / objektuSkripts.kanva.scaleFactor;
 }

 public void OnEndDrag(PointerEventData eventData)
 {
		objektuSkripts.pedejaisVilktais = eventData.pointerDrag;
		kanvasGrupa.alpha = 1f;

		if(objektuSkripts.vaiIstajaVieta == false) {
			kanvasGrupa.blocksRaycasts = true;
		} else {
			objektuSkripts.pedejaisVilktais = null;
			//Debug.Log (skaita.Skait);
		}
		objektuSkripts.vaiIstajaVieta = false;
				
 }

	// Use this for initialization
	void Start () {
		//Piekļūst velkamā objekta CanvasGroup komponentei
		kanvasGrupa = GetComponent<CanvasGroup>();
		//Piekļūs velkamā objektya RectTransform komponentei
		velkObjRectTransf = 
		GetComponent<RectTransform>();
	}
	
	
}
