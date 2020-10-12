using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

// https://www.youtube.com/watch?v=jvtFUfJ6CP8

public class EnemyGraphics : MonoBehaviour
{
    // this script is for AI and shooting + white effect 

    public AudioClip soundEffect;
    private int health = 2;
    public AIPath aiPath;
    SpriteRenderer sr;
    private Material matWhite;
    private Material matDefault;
    private UnityEngine.Object explosionRef;

    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x >= 0.001f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

        void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
        matDefault = sr.material;
        explosionRef = Resources.Load("Explosion");
    }



        void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
            health--;
            sr.material = matWhite;
            if(health<=0)
            {
                KillsSelf();
                Destroy(collision.collider.gameObject);
                Destroy(gameObject);
                AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            }
            else
            {
                Invoke("ResetMaterial", .1f);
            }
          
        }
    }

    void ResetMaterial()
    {
        sr.material = matDefault;
    }

    void KillsSelf()
    {
       GameObject explosion = (GameObject)Instantiate(explosionRef);
       explosion.transform.position = new Vector3(transform.position.x, transform.position.y + .3f, transform.position.z);
    }

}
