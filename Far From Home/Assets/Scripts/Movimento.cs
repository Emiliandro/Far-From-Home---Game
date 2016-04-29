using UnityEngine;
using System.Collections;

public class Movimento : MonoBehaviour {

	[SerializeField] private KeyCode right, left, up, down, run;
	[SerializeField] private float velright, velleft;
	private float o_velright, o_velleft;
	[SerializeField] private int count;
	[SerializeField] private GameObject player;
	private Rigidbody2D player_rb;
	[SerializeField] private bool running;

	void Start () {
		o_velright = velright;
		count = 0;
		running = false;
		StartCoroutine (leftdown ());
		StartCoroutine (getRB());
		o_velleft = velleft;

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

        if (Input.GetKey(right))
        {
            running = false;
            count = 1;
            if (Input.GetKey(run)) running = true;
        }
        else if (Input.GetKey(left))
        {
            running = false;
            count = 2;
            if (Input.GetKey(run)) running = true;
        }
        else if (Input.GetKey(up)) count = 3;
        else if (Input.GetKey(down)) count = 4;
        else count = 0;
        //StartCoroutine(startMoving ());
        StartCoroutine(startRunning());
}
    void FixedUpdate()
    {
        if (count == 1)
        {
            player_rb.velocity = new Vector2(velright, 0f);
        } else if (count == 2) {
            player_rb.velocity = new Vector2(velleft, 0f);
        } else {
            player_rb.velocity = Vector2.zero;
        }
    }

	/*private IEnumerator startMoving (){
		switch (count) {
		case 0:
			    player_rb.velocity = new Vector2(0, 0);
            break;
		case 1:
                player_rb.velocity = new Vector2(velright, 0);
			break;
		case 2:
                player_rb.velocity = new Vector2(velleft, 0);
			break;
		case 3:
			break;
		case 4:
			break;
		}
		yield return new WaitForSeconds (4);
	}*/
    
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
}