﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // this script is for dealing damag to the player ontrigger

    bool _triggered;
    public AudioClip soundEffect;
    private Rigidbody2D rb2D;
    private Animator animator;
        
   ////////////////////////////////////////////////
   //ToDo: es gibt zwei collider die zweimal feuern? ist das der fehler? 
   void OnTriggerEnter2D(Collider2D collider)
    {
        if(_triggered){
            if(collider.gameObject.tag == "Player")
            {
                AudioSource.PlayClipAtPoint(soundEffect, transform.position);
                LiveCounter.health -= 1;
                rb2D = collider.GetComponent<Rigidbody2D>();
                animator = collider.GetComponent<Animator>();
                // move player when he is hurt
                rb2D.velocity = new Vector2(0.0f,20.0f);
                // change animation blinking red and jumping
                animator.SetBool("IsHurt", true);
                animator.SetBool("IsJumping", true);
            }
        }
        _triggered = true;
    }

    ////////////////////////////////////////////////
    public void OnTriggerExit2D(Collider2D collider)
    {
     if (_triggered)
     {
        if(collider.gameObject.tag == "Player")
        {
            animator.SetBool("IsHurt", false);
            animator.SetBool("IsJumping", false);
        }
     }
     _triggered = false;
    }

  

  
}
