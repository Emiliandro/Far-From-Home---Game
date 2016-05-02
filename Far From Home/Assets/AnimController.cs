using UnityEngine;
using System.Collections;

public class AnimController : MonoBehaviour {
	[SerializeField] private Animation anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow))
		{
			if (Input.GetKey(KeyCode.LeftShift)) {
			}
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			if (Input.GetKey(KeyCode.LeftShift)){
				
			}
		}
		else {
			
		}
	}
}
