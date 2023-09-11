using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator anim;
 
    // Update is called once per frame
    void Update()
    {
        // gets our inputs
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        //checks forward
        if (verticalInput > 0f)
        {
            anim.SetBool("Run Forward", true);
            anim.SetBool("Idle", false);
        }
        //checks back
        else if (verticalInput < 0)
        {
            anim.SetBool("Backwards", true);
            anim.SetBool("Idle", false);
        }
        //checks left
        else if (horizontalInput < 0)
        {
            anim.SetBool("Left", true);
            anim.SetBool("Idle", false);
        }
        //checks right
        else if (horizontalInput > 0)
        {
            anim.SetBool("Right", true);
            anim.SetBool("Idle", false);
        }
        //default state to clear all and set idle
        else
        {
            anim.SetBool("Idle", true);
            anim.SetBool("Run Forward", false);
            anim.SetBool("Backwards", false);
            anim.SetBool("Left", false);
            anim.SetBool("Right", false);
        }
    }
}
