using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
    public static Inventory instance;
    [SerializeField] private GameObject Molho, Chave, PDC;

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
    }
}
