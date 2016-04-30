using UnityEngine;
using System.Collections;

public class Escada : MonoBehaviour
{
    public static Escada instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    public void downEscada()
    {
        this.GetComponent<Rigidbody2D>().isKinematic = false;
        this.GetComponent<BoxCollider2D>().isTrigger = false;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Chao")
        {
            this.GetComponent<Rigidbody2D>().isKinematic = true;
            this.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
}
