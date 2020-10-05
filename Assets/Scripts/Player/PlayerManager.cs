using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public int mandelCount;
    public Text mandelNumberText;
    public static PlayerManager instance;
    int score;
    Animator animator;
    Rigidbody2D rb2d;
    Object bulletRef;
    public AudioClip soundEffect;
    public int almondValue = 1;
    bool isfacingLeft;
    public Transform bulletPrefab;
    

    public bool PickupItem(GameObject obj)
    {
    
        switch(obj.tag)
        {
            case "currency":
                // erhöhe die anzahl der mandeln
                //mandelCount++;
                //mandelNumberText.text = "X" + mandelCount.ToString();
                Debug.Log("Currency picked up");
                return true;
                break;
            case "ingredient":
                // kochzutaten kommen ins inventar
                 Debug.Log("Ingredient picked up");
                return true;
                break;
            default:
                return false;
                break;
        }

    }

    void Start()
    {
        bulletRef = Resources.Load("almondBullet");
        rb2d = GetComponent<Rigidbody2D>();
        
        animator = GetComponent<Animator>();

        if(instance == null)
        {
            instance = this;
        }
    }

    public void ChangeScore(int almondValue)
    {
        score += almondValue;
        mandelNumberText.text = "X" + score.ToString();
    }


  
     void Update()
    {

        // If the input is moving the player right and the player is facing left...
        if(Input.GetKeyDown("a"))
            {isfacingLeft = true;}
        else if(Input.GetKeyDown("d"))
            {isfacingLeft = false;}
        
        Debug.Log(isfacingLeft);
         // mousclick left = Fire1M for firing almond
         // || Input.GetKeyDown(KeyCode.Mouse0)
        if(Input.GetKeyDown("e") )
        {
            // score = number of collected almonds; shooting almond -1 to score
            if(score > 0)
            {
                //shootCooldown = shootingRate;
                var shotTransform = Instantiate(bulletPrefab) as Transform;
                // Assign position
                shotTransform.position = transform.position;
                //shotTransform.transform.Rotate(new Vector2(0, 50));
/*  {rb2d.velocity = new Vector3(-15,0);}
        else
        {rb2d.velocity = new Vector3(15,0);}*/

                shotTransform.transform.position = new Vector3(transform.position.x + .4f, transform.position.y + .2f, -1);



                /*WeaponScript weapon = GetComponent<WeaponScript>();
                if (weapon != null)
                {
                    
                    // false because the player is not an enemy
                    weapon.Attack(false);
                    //score -= 1;
                    PlayerManager.instance.ChangeScore(-1);
                }
                */
            }
            else
            {
                AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            }
           
        }
     
    }
}
