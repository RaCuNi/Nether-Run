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
		int rand = Random.Range(1, 30);
		switch(rand) {
			default:
				break;
			
			case 1:
				ObstaclePosRand();
				break;
			
			case 2:
				break;
			
			case 3:
				//ObstaclePosRand();
				break;
			
			case 4:
				break;
			
			case 5:
				//ObstaclePosRand();
				break;

			case 6:
				break;

			case 7:
				break;

			case 8:
				break;

			case 9:
				break;

			case 10:
				break;

			case 11:
				break;

			case 12:
				break;

			case 13:
				break;

			case 14:
				break;

			case 15:
				break;

			case 16:
				break;

			case 17:
				break;

			case 18:
				break;

			case 19:
				break;

			case 20:
				break;

			case 21:
				break;

			case 22:
				break;

			case 23:
				break;

			case 24:
				break;

			case 25:
				break;

			case 26:
				break;

			case 27:
				break;

			case 28:
				break;

			case 29:
				break;

			case 30:
				break;

			

			
		}
	}

	void ObstaclePosRand() {
		GameObject p = GameObject.Find("Dark_Mage");
		float PLAYER_POS_X = p.transform.position.x;
		float OBSTACLE_POS_RANGE = Random.Range(PLAYER_POS_X + 2.56f, PLAYER_POS_X + 4.8f);
		Vector3 Obstacle_Pos = new Vector3 (OBSTACLE_POS_RANGE, 0, 0);
		Instantiate(Resources.Load("obstacle_fire"), Obstacle_Pos, Quaternion.identity);
	}
}
