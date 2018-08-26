using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGGrassBreak : MonoBehaviour {

	float BG_IN_MONITER = 1;
	float BG_WIDTH = 6.73f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveBG();
		BreakBG();
	}

	void BreakBG() {
        GameObject p = GameObject.FindGameObjectWithTag("Player");
		float half_cam = p.transform.position.x - BG_WIDTH * BG_IN_MONITER / 2;

		float bg_posx = this.transform.position.x;
		if(bg_posx < half_cam) {
			Destroy(this.gameObject);
		}
	}

    void MoveBG()
    {
        this.transform.position -= new Vector3(3.365f, 0, 0);
    }
}
