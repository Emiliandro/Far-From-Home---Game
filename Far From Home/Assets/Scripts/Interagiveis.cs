using UnityEngine;
using System.Collections;

public class Interagiveis : MonoBehaviour {
	private bool interagir, M, C, P;
	private GameObject player, camera, escada, chao;
	public enum tipo{
		Portas, 
		Itens,
        Escada
	}
	public tipo Tipo;
	public Vector2 Destino;
	public Vector3 C_Destino;

	void Awake(){
		camera = GameObject.FindGameObjectWithTag ("MainCamera");
		player = GameObject.FindGameObjectWithTag ("Player");
            }

	private void OnTriggerStay2D(Collider2D other){
		if (other.name == player.name) interagir = true;
	}

	private void OnTriggerExit2D(Collider2D exitOther){
		if (exitOther.name == player.name) interagir = false;
	}

	public void Update(){
		if (Input.GetKey(KeyCode.E) && interagir) {
            switch (Tipo) {
                case tipo.Portas:
                    player.transform.position = Destino;
                    camera.transform.position = C_Destino;
                    break;
			    case tipo.Itens:
                    
                    if (this.name == "Item1")
                    {
                        M = true;
                        Destroy(this.gameObject);
                        Inventory.instance.hud(1);
                    }
                    else if (this.name == "Item2")
                    {
                        C = true;
                        Destroy(this.gameObject);
                        Inventory.instance.hud(2);
                    }
                    else if (this.name == "Item3")
                    {
                        P = true;
                        Destroy(this.gameObject);
                        Inventory.instance.hud(3);
                    }
                    break;
            case tipo.Escada:
                    Escada.instance.downEscada();
                    break;
			}
		}
	}
}