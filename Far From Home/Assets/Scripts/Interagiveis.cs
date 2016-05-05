using UnityEngine;
using System.Collections;

public class Interagiveis : MonoBehaviour
{
    public static Interagiveis instance;
    private bool interagir;
    public enum tipo
    {
        Portas = 0,
        Itens = 1,
        Escada = 2,
        Esconderijo = 3
    }
    public tipo Tipo;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
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
            switch (Tipo)
            {
                case tipo.Portas:
                    //Portas.instance.UsePortas();
                    break;
                case tipo.Itens:

                    if (this.name == "Item1")
                    {
                        Destroy(this.gameObject);
                        Inventory.instance.hud(1);
                        Portas.instance.GetMeC(1);
                    }
                    else if (this.name == "Item2")
                    {
                        Destroy(this.gameObject);
                        Inventory.instance.hud(2);
                        Portas.instance.GetMeC(2);
                    }
                    else if (this.name == "Item3")
                    {
                        Destroy(this.gameObject);
                        Inventory.instance.hud(3);
                        Escada.instance.GetPDC(3);
                    }
                    break;
                case tipo.Escada:
                    Escada.instance.UseEscada();
                    break;
            }
        }
        else if (Input.GetKey(KeyCode.UpArrow) && interagir)
        {
            if (Tipo == tipo.Esconderijo) Movimento.instance.Esconder(1);
        }
    }
}