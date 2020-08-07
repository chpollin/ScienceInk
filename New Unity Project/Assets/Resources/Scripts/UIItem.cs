using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItem : MonoBehaviour
{
    public Item item; 
    private Image spriteImage;

    private void Awake()
    {
        spriteImage = GetComponent<Image>();
    }

    public void UpdateItem(Item item)
    {
        if(this.item != null)
        {
            Debug.Log("UpdateItem: item exists" + item.item_id);
            spriteImage.color = Color.white;
            spriteImage.sprite = this.item.icon;
        }
        else
        {
            Debug.Log("UpdateItem: add Icon of "+ item.title + " to Inventory");
            spriteImage.color = Color.white;
            spriteImage.sprite = item.icon;
        }
        
    }
}
