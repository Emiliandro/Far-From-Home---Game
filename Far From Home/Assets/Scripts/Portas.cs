using UnityEngine;
using System.Collections;

public class Portas : MonoBehaviour {

    public static Portas instance;

    private GameObject player, camera;
    private bool M, C;
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
    public void UsePortas()
    {
        if (M == true)
        {
            player.transform.position = Destino_P;
            camera.transform.position = C_Destino_P;
        }
        else if (C == true)
        {
            player.transform.position = Destino_P;
            camera.transform.position = C_Destino_P;
        }
    }
}
