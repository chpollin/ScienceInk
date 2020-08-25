using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeHurt: MonoBehaviour
{
    public GameManager gameManager;

    // 

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Debug.Log("hurt!!!");
            LiveCounter.health -= 1;



        }
    }
}