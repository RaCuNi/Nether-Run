using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSlide : MonoBehaviour {
	Animator anim;
	Rigidbody rb;
	BoxCollider col;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(SlideMove());	
	}
	IEnumerator SlideMove() {
		col = this.GetComponent<BoxCollider>();
		anim = this.GetComponent<Animator>();
		bool is_sliding = anim.GetBool("is_sliding");
		if(Input.GetKeyDown(KeyCode.DownArrow)) {
			col.center = new Vector3 (0.07497542f, -0.1332976f, 0);
			col.size = new Vector3 (2.054229f, 0.4164454f, 0);
			//this.transform.Translate(new Vector3 (0, -0.08f, 0));
			yield return new WaitForSecondsRealtime(0.4f);
			
			this.transform.Translate(new Vector3 ( 0, 0.1f, 0));
			col.center = new Vector3 (-0.2260542f, 0.07919401f, 0);
			col.size = new Vector3 (1.947982f, 1.903886f, 0.2f);
			
			
		}
		
	}
}
