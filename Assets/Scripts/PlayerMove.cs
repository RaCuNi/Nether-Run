using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public float run_speed = 0.1f;
	public float jump_height = 0.1f;
	private bool is_jumping = false;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position += new Vector3 (1, 0, 0) * run_speed;
		rb = this.GetComponent<Rigidbody>();

		if(Input.GetKeyDown(KeyCode.UpArrow) && is_jumping == false) {
			//this.transform.position += new Vector3 (0, 1, 0) * jump_height;
			rb.AddForce(new Vector3 (0, 1, 0) * jump_height, ForceMode.Impulse);

		}
	}

	void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag == "Ground") {
			is_jumping = false;
		}

	}

	void OnCollisionExit(Collision col) {
		if(col.gameObject.tag == "Ground") {
			is_jumping = true;
		}
	}
}
