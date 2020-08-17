using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D col)
    {
        LiveCounter.health -= 1;
    }
}
