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

    public bool PickupItem(GameObject obj)
    {
        switch(obj.tag)
        {
            case "currency":
                // erhöhe die anzahl der mandeln
                mandelCount++;
                //mandelNumberText.text = "X" + mandelCount.ToString();
                return true;
                break;
            case "ingredient":
                // kochzutaten kommen ins inventar
                return true;
                break;
            default:
                return false;
                break;
        }

    }

    void Start()
    {
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
}
