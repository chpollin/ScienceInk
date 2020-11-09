using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public AudioClip soundEffect;
    public int item_id;
    public Item item;
    public Inventory inventory;
    public GameObject questLogPanel;
    public QuestLogManager questLogManager;
    bool _triggered;
    public int almondValue = 1;
    bool isPaused = false;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerManager manager = collision.GetComponent<PlayerManager>();
        // fixing firing OnTrigget Twice; set a boolean value when triggered
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
                        isPaused = true;
                        if(isPaused)
                        {
                            Time.timeScale = 0;
                        }
                        questLogPanel.gameObject.SetActive(true);
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

    // fixing firing OnTrigget Twice; set a boolean value when triggered
    public void OnTriggerExit2D(Collider2D collision)
    {
     if (!_triggered)
     {
         return;
     }
     _triggered = false;
    }

    public void pauseGame()
    {
        if(isPaused){
            Time.timeScale = 1;
            isPaused = false;
        }
        else{
            Time.timeScale = 0;
            isPaused = true;
        }
    }

    public void RemoveItem()
    {
        AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        Destroy(gameObject);
    }




}
