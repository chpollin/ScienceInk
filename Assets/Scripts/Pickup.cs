using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public AudioClip soundEffect;
    public int item_id;
    public Item item;
    public Inventory inventory;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerManager manager = collision.GetComponent<PlayerManager>();
        if (manager)
        {
            bool pickedUp = manager.PickupItem(gameObject);
            if(pickedUp)
            {
                RemoveItem();
                // pick up and add item to the inventory
                //ToDo Almond has id=100; select by tag would be better
                if(item_id<99)
                {
                    inventory.GiveItem(item_id); 
                } 
            }
        }
    }

    public void RemoveItem()
    {
        AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        Destroy(gameObject);
    }




}
