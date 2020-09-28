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

    public void ChangeScore(int mandelValue)
    {
        score += mandelValue;
        mandelNumberText.text = "X" + score.ToString();
    }


  
     void Update()
    {
        bool shoot = Input.GetKeyDown("e");
         //mousclick left = Fire1M for firinf almond
        if(shoot)
        {
            // score = number of colelcted almonds; shooting almond -1 to score
            if(score > 0)
            {
                WeaponScript weapon = GetComponent<WeaponScript>();
                if (weapon != null)
                {
                    // false because the player is not an enemy
                    weapon.Attack(false);
                    score -= 1; 
                }
            }
            else
            {
                AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            }
           
        }
     
    }
}
