using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBreak : MonoBehaviour {

	float BLOCK_IN_MONITER = 20;
	float BLOCK_WIDTH = 0.32f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		BreakBlock();
	}

	void BreakBlock() {
		GameObject p = GameObject.Find("Dark_Mage");
		float half_cam = p.transform.position.x - BLOCK_WIDTH * BLOCK_IN_MONITER / 2;

		float block_posx = this.transform.position.x;
		if(block_posx < half_cam) {
			Destroy(this.gameObject);
		}
	}
}
