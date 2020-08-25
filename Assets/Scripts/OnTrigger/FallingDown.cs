using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDown : MonoBehaviour
{
    public GameManager gameManager;

    // if player falls down somewhere (defined with a trigger with the tag "Falling Down")

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Debug.Log("faaalllling!");
            gameManager.EndGame();

            //ToDo: add here a falling animation
            //add losing 1 life and respawn somewhere

        }
    }
}