using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointScript : MonoBehaviour
{
    private GameManager gameManager;
    bool _triggered;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
    if(_triggered){
        if(collision.CompareTag("Player"))
        {
            gameManager.lastCheckPointPos = transform.position;
        }
    }
    _triggered = true;
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
     if (!_triggered)
     {
         return;
     }
     _triggered = false;
    }
}

