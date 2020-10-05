using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    Rigidbody2D rb2d;
    bool isFacingLeft = false;
    public GameObject player;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        // destroy almond bullet after some time
        Invoke("DestroySelf", .5f);
        
    }

    void FixedUpdate()
    {
        //change x to minus; bullet goes left
        /*if(isFacingLeft)
        {rb2d.velocity = new Vector3(-15,0);}
        else
        {rb2d.velocity = new Vector3(15,0);}
       */
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
