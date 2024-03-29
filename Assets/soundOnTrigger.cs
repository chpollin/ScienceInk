﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOnTrigger : MonoBehaviour
{
    public AudioClip clip;
    public float volume=1;
    bool  hasPlayed = false;

    void OnTriggerEnter2D(Collider2D collider)
    {

        if(!hasPlayed){
            if(collider.gameObject.tag == "Player")
            {
                 AudioSource.PlayClipAtPoint(clip, transform.position, volume);
                 hasPlayed = true;
            }
        }
       
    }
}
