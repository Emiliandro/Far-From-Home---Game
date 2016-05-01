using UnityEngine;
using System.Collections;

public class Escada : MonoBehaviour
{
    public static Escada instance;
    private GameObject player, camera;
    private bool TaNoChao, P;
    public Vector2 Destino;
    public Vector3 C_Destino;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        player = GameObject.FindGameObjectWithTag("Player");
        TaNoChao = false;
        P = false;
    }
    public void GetPDC(int itemIdx)
    {
        if (itemIdx == 3)
        {
            P = true;
        }
    }
    public void UseEscada()
    {
        if (TaNoChao == false && P == true)
        {
            this.GetComponent<Rigidbody2D>().isKinematic = false;
            this.GetComponent<BoxCollider2D>().isTrigger = false;
            Inventory.instance.hud(6);

        }
        else if (TaNoChao == true)
        {
            player.transform.position = Destino;
            camera.transform.position = C_Destino;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Chao")
        {
            this.GetComponent<Rigidbody2D>().isKinematic = true;
            this.GetComponent<BoxCollider2D>().isTrigger = true;
            TaNoChao = true;
        }
    }
}

