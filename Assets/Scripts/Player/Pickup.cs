using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public AudioClip soundEffect;
    public int item_id;
    public Item item;
    public Inventory inventory;
    public QuestLogManager questLogManager;
    bool _triggered;
    public int almondValue = 1;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerManager manager = collision.GetComponent<PlayerManager>();
        // fixing fireing OnTrigget Twice; set a boolean value when triggered
        if(_triggered){
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
                        // also add ingredient in the QuestLog
                        questLogManager.addIngredientToQuest(item_id);
                        
                    } 
                    if(item_id == 100)
                    {
                        PlayerManager.instance.ChangeScore(almondValue);
                    }
                }
            Physics2D.IgnoreCollision(collision, GetComponent<Collider2D>());    
            }
        }
         _triggered = true;
    }

    // fixing fireing OnTrigget Twice; set a boolean value when triggered
    public void OnTriggerExit2D(Collider2D collision)
    {
     if (!_triggered)
     {
         return;
     }
     _triggered = false;
    }

    public void RemoveItem()
    {
        AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        Destroy(gameObject);
    }




}
