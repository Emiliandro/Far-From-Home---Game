using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	public enum items {
		MOLHO = 1,
		PEDECABRA = 2,
		CHAVE = 3
	}
	[SerializeField] private items _invetario;

	public void inventario(){
		switch(_invetario){
		case items.MOLHO:
			break;
		case items.PEDECABRA:
			break;
		case items.CHAVE:
			break; 
		}
	}
}
