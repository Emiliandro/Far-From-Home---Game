using UnityEngine;
using System.Collections;

public class Portas : MonoBehaviour {

    public static Portas instance;

    private GameObject player, camera;
    private bool M, C, interagir;
    public Vector2 Destino_P;
    public Vector3 C_Destino_P;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        player = GameObject.FindGameObjectWithTag("Player");

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player") interagir = true;
    }

    private void OnTriggerExit2D(Collider2D exitOther)
    {
        if (exitOther.tag == "Player") interagir = false;
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.E) && interagir)
        {
            player.transform.position = Destino_P;
            camera.transform.position = C_Destino_P;
        }
    }
    public void GetMeC(int itemIdx)
    {
        if (itemIdx == 1)
        {
            M = true;
        }
        else if (itemIdx == 2)
        {
            C = true;
        }
    }
}
