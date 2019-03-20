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
    
    void FixedUpdate()
    {
        controller.Move(horizantalMove * Time.deltaTime,crouch,jump);
        jump = false;
       

    }

    void Update()
    {
       horizantalMove = Input.GetAxisRaw("Horizontal") * runspeed;
        animator.SetFloat("speed", Mathf.Abs( horizantalMove));
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }


    }
}
