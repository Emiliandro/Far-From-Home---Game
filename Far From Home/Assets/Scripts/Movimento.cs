using UnityEngine;
using System.Collections;

public class Movimento : MonoBehaviour {

    public static Movimento instance;

	[SerializeField] private KeyCode right, left, up, down, run;
	[SerializeField] private float velright, velleft;
	private float o_velright, o_velleft;
	[SerializeField] private int count;
	[SerializeField] private GameObject player;
	private Rigidbody2D player_rb;
	[SerializeField] private bool running, escondido, esquerdai;

    void Start () {
        if (instance == null)
        {
            instance = this;
        }
        o_velright = velright;
		count = 0;
		StartCoroutine (leftdown ());
		StartCoroutine (getRB());
		o_velleft = velleft;
        escondido = false;

	}

	IEnumerator leftdown(){
		velleft = velleft * -1;
		yield return new WaitForSeconds (0);
		print ("valores corrigidos");
	}

	IEnumerator getRB() { 
		player = GameObject.FindGameObjectWithTag ("Player");
		player_rb = player.GetComponent<Rigidbody2D> ();
		yield return new WaitForSeconds (3);
		print ("player is connected");
	}

	void Update(){
		// animacoes

		if (Input.GetKeyDown(right) && !escondido){
			player.GetComponent<Animator>().Play("Player_walk",-1,0f);
			//if (Input.GetKeyDown(run) && !escondido){
				//player.GetComponent<Animator>().Play("Player_run",-1,0f);
			//}
			esquerdai = false;
		} else if (Input.GetKeyDown(left) && !escondido) {
			player.GetComponent<Animator>().Play("Player_walk_l",-1,0f);
			//if (Input.GetKeyDown(run) && !escondido ){
				//player.GetComponent<Animator>().Play("Player_run_l",-1,0f);
			//}
			esquerdai = true;
			}  else {
			if (Input.GetKeyUp(right) && !esquerdai && !escondido) {
				player.GetComponent<Animator>().Play("Player_Idle",-1,0f);
			} else if (Input.GetKeyUp(left) && esquerdai && !escondido) {
				player.GetComponent<Animator>().Play("Player_Idle_l",-1,0f);

			}
		}

		//

        if (Input.GetKey(right))
        {
            running = false;
            count = 1;
			if (Input.GetKey(run)) {
				running = true;
			}
        }
        else if (Input.GetKey(left))
        {
            running = false;
            count = 2;
			if (Input.GetKey(run)) {
				running = true;
			}
        }
        else if (Input.GetKey(down)) Esconder(2);
        else count = 0;
        StartCoroutine(startRunning());
}
    void FixedUpdate()
    {
        if (count == 1 && escondido == false)
        {
            player_rb.velocity = new Vector2(velright, 0f);
        } else if (count == 2 && escondido == false) {
            player_rb.velocity = new Vector2(velleft, 0f);
        } else {
            player_rb.velocity = Vector2.zero;
        }
    }    
    private IEnumerator startRunning (){
		switch (running){
		case true:
			velleft = o_velleft*2f;
			velright = o_velright*2f;
			break;
		case false:
			velleft = o_velleft;
			velright = o_velright;
			break;
		}
		yield return new WaitForSeconds (10);
	}
    public void Esconder(int EscIdx)
    {
        if (EscIdx == 1)
        {
            escondido = true;
            player.GetComponent<Rigidbody2D>().isKinematic = true;
            player.GetComponent<BoxCollider2D>().isTrigger = true;
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        else
        {
            escondido = false;
            player.GetComponent<Rigidbody2D>().isKinematic = false;
            player.GetComponent<BoxCollider2D>().isTrigger = false;
            player.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}