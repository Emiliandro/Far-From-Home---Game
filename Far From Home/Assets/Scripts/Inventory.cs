using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
    public static Inventory instance;
    private GameObject Molho, Chave, PDC;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        Molho = GameObject.Find("Molho");
        Chave = GameObject.Find("Chave");
        PDC = GameObject.Find("PDC");
    }

	public void hud(int itemIdx)
        {
        //De 1-3 para ativar no HUD, de 4-6 para desativar.
        if (itemIdx == 1)
        {
            Molho.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (itemIdx == 2)
        {
            Chave.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (itemIdx == 3)
        {
            PDC.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (itemIdx == 4)
        {
            Molho.GetComponent<SpriteRenderer>().enabled = false;
        }
        else if (itemIdx == 5)
        {
            Chave.GetComponent<SpriteRenderer>().enabled = false;
        }
        else if (itemIdx == 6)
        {
            PDC.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
