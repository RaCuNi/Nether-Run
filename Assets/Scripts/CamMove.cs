using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour {

	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		GameObject player = GameObject.Find("Dark_Mage");

		this.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -10);

		
	}
}
