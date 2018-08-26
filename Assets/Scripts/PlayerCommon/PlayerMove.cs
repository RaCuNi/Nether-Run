using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float jump_height = 10f;
    public bool is_jumping;
    Rigidbody rb;

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();
        GameObject p = GameObject.FindGameObjectWithTag("Player");
    }
    void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            is_jumping = true;
        }

    }

    void FixedUpdate()
    {
        Jump();
    }

    void Jump()
    {
        if(!is_jumping)
        {
            return;
        }

        rb.AddForce(new Vector3(0, 3f, 0), ForceMode.Impulse);

        is_jumping = false;
    }

    void OnCollisionEnter(Collision col)
    {
        GameObject p = GameObject.FindGameObjectWithTag("Player");
        if (col.Equals(p))
        {

        }
    }
}