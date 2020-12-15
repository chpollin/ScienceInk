using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol_easy : MonoBehaviour
{
    public float speed;
    public float distance;
    private bool movingRight = true; 
    public Transform groundDetection;
    public AudioClip soundEffect;
    public int health;
    SpriteRenderer sr;
    private Material matWhite;
    private Material matDefault;
    private UnityEngine.Object explosionRef;

    void Update(){

        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(groundInfo.collider == false){
            if(movingRight == true){
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            } 
            else{
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            } 
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
