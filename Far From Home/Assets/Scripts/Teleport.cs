using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	[SerializeField] private GameObject player;
	[SerializeField] private int count;
	[SerializeField] private Collision collision;
	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player");
		count = 0;
	}

	//private void OnCollisionEnter(Collision collision){
	void Update(){
		if (collision.gameObject.name == "t1") count = 1;
		if (collision.gameObject.name == "t2") count = 2;
		if (collision.gameObject.name == "t3") count = 3;
		if (collision.gameObject.name == "t4") count = 4;
		if (collision.gameObject.name == "t5") count = 5;
		if (collision.gameObject.name == "t6") count = 6;
		if (collision.gameObject.name == "t7") count = 7;
	}

	private void OnTriggerEnter2D(Collider2D other){
		switch (count) {
		case 1:
			player.transform.position = new Vector2(-8,-1);
			break;
		case 2:
			player.transform.position = new Vector2(-8,-1);
			break;
		case 3:
			player.transform.position = new Vector2(-8,-1);
			break;
		case 4:
			player.transform.position = new Vector2(-8,-1);
			break;
		case 5: 
			player.transform.position = new Vector2(-8,-1);
			break;
		case 6: 
			player.transform.position = new Vector2(-8,-1);
			break;
		case 7:
			player.transform.position = new Vector2(-8,-1);
			break;
		}
	}
}
