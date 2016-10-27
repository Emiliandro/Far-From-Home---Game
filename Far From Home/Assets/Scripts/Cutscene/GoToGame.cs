using UnityEngine;
using System.Collections;

public class GoToGame : MonoBehaviour {
    public string cenaseguinte;

    // Use this for initialization
    void Update () {
		Invoke("changeScene",27f);
	}

    void FixedUpdate()
    {
        if (Input.anyKey)
        {
            changeScene();
        }
    }

    // Update is called once per frame
    void changeScene () {
		Application.LoadLevel(cenaseguinte);
	}
}
