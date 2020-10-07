using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public AudioClip soundEffect;
    private int health = 2;
    // materials
    private Material matWhite;
    private Material matDefault;
    private UnityEngine.Object explosionRef;
    SpriteRenderer sr;

    // Start is called before the first frame update
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
