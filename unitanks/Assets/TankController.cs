using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour {
	
	public float speed = 20;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		rigidbody.velocity = Vector3.zero;
		if (Input.GetKey(KeyCode.RightArrow)){
			rigidbody.AddForce(transform.right * speed, ForceMode.Impulse);
			//transform.rotation = initialRot;
			
	
		}
			if (Input.GetKey(KeyCode.LeftArrow)){
			rigidbody.AddForce(-transform.right * speed, ForceMode.Impulse);
			//transform.rotation = initialRot;
			
	
		}
			if (Input.GetKey(KeyCode.DownArrow)){
			rigidbody.AddForce(-transform.forward * speed, ForceMode.Impulse);
			//transform.rotation = initialRot;
			
	
		}
			if (Input.GetKey(KeyCode.UpArrow)){
			rigidbody.AddForce(transform.forward * speed, ForceMode.Impulse);
			//transform.rotation = initialRot;
		}
	}
}
