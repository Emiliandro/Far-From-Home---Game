﻿using UnityEngine;
using System.Collections;

public class MenuI : MonoBehaviour {
    [SerializeField]
    private GameObject[] items;
    private int count;
    [Header("Cenas Seguintes")]
    public string cena1;
    public string cena2;

    // Use this for initialization
    void Start ()
    {
        count = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (count == 0)
        {
            items[0].transform.localScale = new Vector3(2f, 2f, 2f);
            items[1].transform.localScale = new Vector3(1f, 1f, 1f);
            if (Input.GetKey(KeyCode.DownArrow)) {
                count = 1;
            }
            if (Input.GetKey(KeyCode.E))
            {
                Application.LoadLevel(cena1);
            }
        }
        else {
            items[1].transform.localScale = new Vector3(2f, 2f, 2f);
            items[0].transform.localScale = new Vector3(1f, 1f, 1f);
            if (Input.GetKey(KeyCode.UpArrow))
            {
                count = 0;
            } 
            if (Input.GetKey(KeyCode.E))
            {
                Application.LoadLevel(cena2);
            }
        }
    }
}
