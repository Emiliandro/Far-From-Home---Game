using UnityEngine;
using System.Collections;

public class GoToGame : MonoBehaviour {

	// Use this for initialization
	void Update () {
		Invoke("changeScene",30f);
	}

	// Update is called once per frame
	void changeScene () {
		Application.LoadLevel("tutorial");
	}
}
