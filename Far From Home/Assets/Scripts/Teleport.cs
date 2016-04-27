using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	private GameObject player, camera;
	void Awake(){
		camera = GameObject.FindGameObjectWithTag ("MainCamera");
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	private void OnTriggerEnter2D(Collider2D other){
		switch (other.gameObject.name) {
		case "t1":
			player.transform.position = new Vector2 (-7, 30);
			camera.transform.position = new Vector3 (0, 31, -10);
			break;
		case "t2":
			player.transform.position = new Vector2(-7,59.4f);
			camera.transform.position = new Vector3 (0, 61, -10);
			break;
		case "t3":
			player.transform.position = new Vector2(7,-2);
			camera.transform.position = new Vector3 (0, 0, -10);
			break;
		case "t4":
			player.transform.position = new Vector2(53,-0.1f);
			camera.transform.position = new Vector3 (60, 1.5f, -10);
			break;
		case "t5": 
			player.transform.position = new Vector2(8,30);
			camera.transform.position = new Vector3 (0, 31, -10);
			break;
		case "t6": 
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (62, 30, -10);
			break;
		case "t7":
			player.transform.position = new Vector2(8,58);
			camera.transform.position = new Vector3 (0, 62, -10);
			break;
		case "t8":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (62, 60, -10);
			break;
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (0, 0, -10);
		case "t9":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (0, 0, -10);
			break;
		case "t10":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (110, 1, -10);
			break;
		case "t11":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (0, 0, -10);
			break;
		case "t12":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (109.5f, 30.5f, -10);
			break;
		case "t13":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (0, 0, -10);
			break;
		case "t14":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (110.4f, 59, -10);
			break;
		case "t15":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (0, 0, -10);
			break;
		case "t16":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (146.2f, 1, -10);
			break;
		case "t17":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (0, 0, -10);
			break;
		case "t18":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (0, 0, -10);
			break;
		case "t19":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (0, 0, -10);
			break;
		case "t20":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (0, 0, -10);
			break;
		case "t21":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (0, 0, -10);
			break;
		case "t22":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (0, 0, -10);
			break;
		case "t23":
			player.transform.position = new Vector2(-7,-1);
			camera.transform.position = new Vector3 (0, 0, -10);
			break;

		}
	}
}
