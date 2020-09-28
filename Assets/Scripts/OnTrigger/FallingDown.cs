using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDown : MonoBehaviour
{
    bool _triggered;
    public AudioClip soundEffect;
    private Rigidbody2D rb2D;
    private Animator animator;

    // if player falls down somewhere (defined with a trigger with the tag "Falling Down")

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(_triggered){
            if(collider.gameObject.tag == "Player")
            {
                AudioSource.PlayClipAtPoint(soundEffect, transform.position);
                LiveCounter.health -= 1;
                rb2D = collider.GetComponent<Rigidbody2D>();
                animator = collider.GetComponent<Animator>();
                animator.SetBool("IsHurt", true);
                animator.SetBool("IsJumping", true);

            }
        }
        _triggered = true;
    }

    ////////////////////////////////////////////////
    public void OnTriggerExit2D(Collider2D collider)
    {
     if (!_triggered)
     {
        animator.SetBool("IsHurt", false);
        animator.SetBool("IsJumping", false);
        collider.transform.position = new Vector2(0,0);
     }
     _triggered = false;
    }

}