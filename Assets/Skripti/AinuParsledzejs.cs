using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {

	public void UzSakumu(){
		SceneManager.LoadScene(0, LoadSceneMode.Single);
	}

	public void UzUI() {
		SceneManager.LoadScene(1, LoadSceneMode.Single);
	}

	public void Apturet() {
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
