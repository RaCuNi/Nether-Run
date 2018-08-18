using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float run_speed = 0.1f;
    public float jump_height = 10f;
    public bool is_jumping = false;
    public bool col_check = false;
    private float ground_height = -0.02545023f;
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position += new Vector3(1, 0, 0) * run_speed;
        rb = this.GetComponent<Rigidbody>();
        GameObject p = GameObject.FindGameObjectWithTag("Player");

        if (Input.GetKeyDown(KeyCode.UpArrow) && is_jumping == false)
        {
            is_jumping = true;
            //this.transform.position += new Vector3 (0, 1, 0) * jump_height;
            rb.AddForce(new Vector3(0, 1, 0) * jump_height, ForceMode.Impulse);
        }

        if (Mathf.Abs(this.transform.position.y - ground_height) <= 0.00001f)
        {
            is_jumping = false;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col_check == false)
        {
            col_check = true;
        }
    }
}
        /*
		if(col.gameObject.tag == "Ground") {
			is_jumping = false;
		}

	}

	void OnCollisionExit(Collision col) {
		if(col.gameObject.tag == "Ground") {
			//is_jumping = true;
		}
	}
}
*/