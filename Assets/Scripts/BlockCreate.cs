using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreate : MonoBehaviour {
	// Use this for initialization
	void Start () {
		/*
		GameObject p = GameObject.Find("Dark_Mage");
		Vector3 first_block_pos = new Vector3(p.transform.position.x, p.transform.position.y - 0.32f, 0);
		Vector3 last_block_pos = new Vector3(first_block_pos.x + 0.32f, first_block_pos.y, first_block_pos.z);
		Instantiate(Resources.Load ("FloorBlock"), first_block_pos, Quaternion.identity);
		*/

	}
	
	// Update is called once per frame
	void Update () {
		CreateBlock();
		
	}

	void CreateBlock() {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
			Vector3 block_pos = new Vector3 (player.transform.position.x + 3f, -0.7f, 0);
		    Instantiate(Resources.Load ("Ground"), block_pos, Quaternion.identity);
	}
}
