using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSlide : MonoBehaviour {
	Animator anim;
	BoxCollider col;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SlideMove();	
	}
	void SlideMove() {
		col = this.GetComponent<BoxCollider>();
		anim = this.GetComponent<Animator>();
		bool is_sliding = anim.GetBool("is_sliding");
		if(Input.GetKeyUp(KeyCode.DownArrow)) {
			anim.SetBool("is_sliding", false);
			col.center = new Vector3 (-0.2260542f, 0.07919401f, 0);
			col.size = new Vector3 (1.947982f, 1.903886f, 0.2f);
			//Debug.Log(is_sliding);
		}
		if(Input.GetKey(KeyCode.DownArrow) && is_sliding) {
			col.center = new Vector3 (0.07497542f, -0.1332976f, 0);
			col.size = new Vector3 (2.054229f, 0.4164454f, 0.2f);
			//Debug.Log(is_sliding);
		}
	}
}
