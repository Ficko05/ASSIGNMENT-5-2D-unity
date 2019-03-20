using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    public CharacterController2D controller;
    private float timebtwAttack;
    public float startTimeAttack;
    public Animator animator;

    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public int damage;

    void Update()
    {
        if(timebtwAttack <= 0)
        {

            if (Input.GetButtonDown("Fire1"))
            {
                print("press 1");
                animator.SetBool("isattacking", true);
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                   // enemiesToDamage[i].GetComponent<Enemy>.health -= damage;
                }
            }
            else if (Input.GetButtonUp("Fire1"))
            {
                animator.SetBool("isattacking", false);
            }



            timebtwAttack = startTimeAttack;
        }
        else {
            timebtwAttack -= Time.deltaTime;
                }
    }
}
