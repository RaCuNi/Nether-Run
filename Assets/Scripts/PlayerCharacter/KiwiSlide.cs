using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiwiSlide : MonoBehaviour {
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
			//yield return new WaitForSecondsRealtime(0.3f);
			anim.SetBool("is_sliding", false);
			col.center = new Vector3 (-0.05738512f, 0.1022065f, 0);
			col.size = new Vector3 (1.888859f, 1.405576f, 0.2f);
			//Debug.Log(is_sliding);
		}
		if(Input.GetKey(KeyCode.DownArrow) && is_sliding) {
			col.center = new Vector3 (-0.05738512f, 0.3090555f, 0);
			col.size = new Vector3 (1.888859f, 0.9918779f, 0.2f);
			//Debug.Log(is_sliding);
		}
		
		
	}
}
