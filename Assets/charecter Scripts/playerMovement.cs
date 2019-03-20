using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    float horizantalMove = 0f;
    public float runspeed = 40f;
    bool jump = false;
    bool crouch = false;
    bool isCrouching = false;


    void FixedUpdate()
    {
        controller.Move(horizantalMove * Time.deltaTime,crouch,jump);
        jump = false;
        //crouch = false;

    }

    void Update()
    {
       horizantalMove = Input.GetAxisRaw("Horizontal") * runspeed;
        animator.SetFloat("speed", Mathf.Abs( horizantalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isjumping", true);
        }
        


        if (Input.GetButtonDown("Crouch"))
        {
            animator.SetBool("iscrouching", true);
            crouch = true;

        }
        else if (Input.GetButtonUp("Crouch"))
        {
            animator.SetBool("iscrouching", false);
            crouch = false;
        }
    }

    public void onLanding()
    {
            animator.SetBool("isjumping", false);
    }
}
