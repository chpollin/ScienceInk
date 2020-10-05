using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BulletScript : MonoBehaviour
{
    Rigidbody2D rb2d;
    bool isFacingLeft = false;
    public GameObject player;
    public AudioClip soundEffect;

    void Start()
    {
        AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        rb2d = GetComponent<Rigidbody2D>();
        // destroy almond bullet after some time
        Invoke("DestroySelf", .75f);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // collision with middle destroys almond bullet
        if(collision.gameObject.CompareTag("Ground"))
        {
            DestroySelf();
        }
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}
