using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mandel : MonoBehaviour
{
    public int mandelValue = 1;

    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerManager.instance.ChangeScore(mandelValue);
        }
    }
}
