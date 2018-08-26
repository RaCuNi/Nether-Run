using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CreateObstacle();
		
	}

	void CreateObstacle() {
		int rand = Random.Range(1, 100);
		switch(rand) {
			default:
				break;
			
			case 1:
				ObstaclePosRand();
				break;
		}
	}

	void ObstaclePosRand() {
        GameObject p = GameObject.FindGameObjectWithTag("Player");
		float PLAYER_POS_X = p.transform.position.x;
		float OBSTACLE_POS_RANGE = Random.Range(PLAYER_POS_X + 2.56f, PLAYER_POS_X + 4.8f);
		Vector3 Obstacle_Pos = new Vector3 (OBSTACLE_POS_RANGE, 0, 0);
		Instantiate(Resources.Load("obstacle_fire"), Obstacle_Pos, Quaternion.identity);
	}
}
