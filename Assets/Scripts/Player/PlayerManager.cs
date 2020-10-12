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
    bool isFacingLeft;
    //public Transform bulletPrefab;
    public Rigidbody2D bulletPrefab;


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
        // get the direction the player looks (maybe hack? sry^^)
        if(Input.GetKeyDown("a"))
            {isFacingLeft = true;}
        else if(Input.GetKeyDown("d"))
            {isFacingLeft = false;}
        
         // mousclick left = Fire1M for firing almond
         // || Input.GetKeyDown(KeyCode.Mouse0)
        if(Input.GetKeyDown("e") )
        {
            // score = number of collected almonds; shooting almond -1 to score
            if(score > 0)
            {
                Rigidbody2D shotTransform = Instantiate(bulletPrefab);
                shotTransform.transform.position = transform.position;

                if(isFacingLeft)
                    {shotTransform.velocity = new Vector3(-15,0);}
                else
                    {shotTransform.velocity = new Vector3(15,0);}
                // ToDo: weil gameoject wird das zweimal geamcht?! 
                score = score - 1;
                PlayerManager.instance.ChangeScore(-1);
            }
            else
            {
                AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            }
           
        }
     
    }
}
