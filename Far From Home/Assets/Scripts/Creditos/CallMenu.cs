using UnityEngine;
using System.Collections;

public class CallMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("changeScene",60f);
	}
	
	// Update is called once per frame
	void changeScene () {
		Application.LoadLevel("MenuInicial");
	}
}
