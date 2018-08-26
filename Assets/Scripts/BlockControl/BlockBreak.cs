using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBreak : MonoBehaviour {

	float BLOCK_IN_MONITER = 7;
	float BLOCK_WIDTH = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveBlock();
		BreakBlock();
	}

	void BreakBlock() {
        GameObject p = GameObject.FindGameObjectWithTag("Player");
		float half_cam = p.transform.position.x - BLOCK_WIDTH * BLOCK_IN_MONITER / 2;

		float block_posx = this.transform.position.x;
		if(block_posx < half_cam) {
			Destroy(this.gameObject);
		}
	}

    void MoveBlock()
    {
        this.transform.position -= new Vector3(1, 0, 0);
    }
}
