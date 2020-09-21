using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeHurt: MonoBehaviour
{
    public GameManager gameManager;
    bool _triggered;

    ////////////////////////////////////////////////
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(_triggered){
            if(collider.gameObject.tag == "Player")
            {
                Debug.Log("hurt!!!");
                LiveCounter.health -= 1;



            }
        }
        _triggered = true;
    }

    ////////////////////////////////////////////////
    public void OnTriggerExit2D(Collider2D collision)
    {
     if (!_triggered)
     {
         return;
     }
     _triggered = false;
     Debug.Log("exit");
    }

}