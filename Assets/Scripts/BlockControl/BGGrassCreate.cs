using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGGrassCreate : MonoBehaviour {

	// Use this for initialization
    void Start () {

	}
	
	void Update () {
		CreateBG();
		
	}

	void CreateBG() {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector3 block_pos = new Vector3 (player.transform.position.x + 6.73f, -0.06f, 0);
		Instantiate(Resources.Load ("BGNetherGrass"), block_pos, Quaternion.identity);
	}
}
