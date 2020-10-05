using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public AudioClip soundEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
           //Debug.Log("AAAAAAAAAA");
        if(collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("AAAAAAAAAABB");
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(soundEffect, transform.position);

        }
    }

  
}
