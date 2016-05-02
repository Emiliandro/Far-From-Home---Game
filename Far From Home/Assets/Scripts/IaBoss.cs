using UnityEngine;
using System.Collections;

public class IaBoss : MonoBehaviour {
    [SerializeField] private float velright, velleft;
    [SerializeField] private int procura;
    private Rigidbody2D rb;
    public Vector2 B_Destino;

    // Use this for initialization
    void Start () {
        procura = 0;
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(100f, 0f));

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Boss1" && procura < 4)
        {
            rb.velocity = new Vector2(velleft, 0f);
            procura += 1;
        }
        else if (other.tag == "Boss2" && procura < 3)
        {
            rb.velocity = new Vector2(velright, 0f);
            procura += 1;
        }
        else if (other.tag == "Boss2" && procura == 4) TelBoss();
    }
    private void TelBoss()
    {
        this.transform.position = B_Destino;
    }
}
