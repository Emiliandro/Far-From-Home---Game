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
		if (Input.anyKey) {
			if (Input.GetKeyDown (right)) count = 1;
			if (Input.GetKeyDown (left)) count = 2;
			if (Input.GetKeyDown (up)) count = 3;
			if (Input.GetKeyDown (down)) count = 4;
		} else {
			count = 0;
		}
		if (Input.anyKey) {
			if (Input.GetKeyDown (run)) running = true;
		} else {
			running = false;
		}
		StartCoroutine(startMoving ());
		StartCoroutine(startRunning());
	}

	private IEnumerator startMoving (){
		switch (count) {
		case 0:
			player_rb.AddForce (new Vector2 (0,0),ForceMode2D.Impulse);
			break;
		case 1:
			player_rb.AddForce (new Vector2 (velright, 0), ForceMode2D.Impulse);
			break;
		case 2:
			player_rb.AddForce (new Vector2 (velleft,0),ForceMode2D.Impulse);
			break;
		case 3:
			break;
		case 4:
			break;
		}
		yield return new WaitForSeconds (4);
	}

	private IEnumerator startRunning (){
		switch (running){
		case true:
			velleft = o_velleft*1.3f;
			velright = o_velright*1.3f;
			break;
		case false:
			velleft = o_velleft;
			velright = o_velright;
			break;
		}
		yield return new WaitForSeconds (10);

	}
}
