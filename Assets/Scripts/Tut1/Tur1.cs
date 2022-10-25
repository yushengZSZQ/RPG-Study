 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tur1 : MonoBehaviour
{
    public Animator animator;
    
    public void Attack()
    {
        animator.SetTrigger("BaseLayer.Attack");
    }

    public void Idle()
    {
        animator.SetTrigger("BaseLayer.Idle");
    }

    public void Jump()
    {
        animator.SetTrigger("BaseLayer.Jump");
    }

}
