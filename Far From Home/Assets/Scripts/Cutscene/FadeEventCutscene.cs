using UnityEngine;
using System.Collections;

public class FadeEventCutscene : MonoBehaviour {

    public GameObject fadeOut, FadeIn;
    public Transform position;


	// Use this for initialization
	void Start () {
        Invoke("InstanciarFade", 4.4f);
        Invoke("InstanciarFadeIn", 22f);
	}
	
	// Update is called once per frame
	void InstanciarFade () {
        Instantiate(fadeOut, position);
	}
    void InstanciarFadeIn()
    {
        Instantiate(FadeIn, position);
    }
}
