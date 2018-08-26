using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour {
    Animator anim;
    Rigidbody rb;

    // Use this for initialization
    void Start ()
    {
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        anim = this.GetComponent<Animator>();
        //anim.SetBool("is_sliding", false);
        bool is_sliding = anim.GetBool("is_sliding");
        bool is_jumping = anim.GetBool("is_jumping");
        if (Input.GetKeyDown(KeyCode.UpArrow) && is_jumping == false && is_sliding == false)
        {
            StartCoroutine(Jump());
        }

        if(Input.GetKeyDown(KeyCode.DownArrow) && is_jumping == false && is_sliding == false)
        {
            StartCoroutine(Slide());
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKeyDown(KeyCode.DownArrow)) {
            //anim.ResetTrigger("doJumping");
            anim.ResetTrigger("doSliding");
            anim.Play("Jump");
            return;
            
        }
        

    }

    IEnumerator Jump() {
        anim.ResetTrigger("doJumping");
        rb.AddForce(new Vector3(0, 3f, 0), ForceMode.Impulse);
        anim.SetBool("is_jumping", true);
        anim.SetTrigger("doJumping");
        yield return new WaitForSecondsRealtime(0.7f);
        anim.SetBool("is_jumping", false);
    }

    IEnumerator Slide() {
        anim.ResetTrigger("doSliding");
        anim.SetBool("is_sliding", true);
        anim.SetTrigger("doSliding");
        yield return new WaitForSecondsRealtime(0.7f);
        anim.SetBool("is_sliding", false);
    }
}
