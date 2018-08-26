using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreate : MonoBehaviour {

    void Start () {

	}
	
	void Update () {
		CreateBlock();
		
	}

	void CreateBlock() {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            Vector3 block_pos = new Vector3 (player.transform.position.x + 3f, -0.675f, 0);
		    Instantiate(Resources.Load ("Ground"), block_pos, Quaternion.identity);
	}
}
