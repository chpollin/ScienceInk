using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter (Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "FallingDown")
        {
            Debug.Log("faaalllling!");
        }
    }
}
