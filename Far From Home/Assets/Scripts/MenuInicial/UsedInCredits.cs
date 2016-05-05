using UnityEngine;
using System.Collections;

public class UsedInCredits : MonoBehaviour {

	void Update ()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Application.LoadLevel("MenuInicial");   
        }
	}
}
