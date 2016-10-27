using UnityEngine;
using System.Collections;

public class UsedInCredits : MonoBehaviour {

    public string level;
	void Update ()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Application.LoadLevel(level);   
        }
	}
}
