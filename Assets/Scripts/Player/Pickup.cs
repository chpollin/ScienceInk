using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    public GameObject PopUpPanel;
    public ItemDatabase itemDatabase;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(item_id == 666)
        {
            if( LiveCounter.health < 3)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                AudioSource.PlayClipAtPoint(soundEffect, transform.position);
                LiveCounter.health += 1;
            }
        }
        else
        {
            PlayerManager manager = collision.GetComponent<PlayerManager>();
            // fixing firing OnTrigget Twice; set a boolean value when triggered
            if(_triggered){
                if (manager)
                {
                    bool pickedUp = manager.PickupItem(gameObject);
                    if(pickedUp)
                    {
                        gameObject.GetComponent<SpriteRenderer>().enabled = false;
                        AudioSource.PlayClipAtPoint(soundEffect, transform.position);
                        // pick up and add item to the inventory
                        //ToDo Almond has id=100; select by tag would be better
                        if(item_id<99)
                        {
                            inventory.GiveItem(item_id);
                            // also add ingredient in the QuestLog
                            questLogManager.addIngredientToQuest(item_id);
                            Item ingredient = itemDatabase.GetItemByID(item_id);
                            // show text that ingredient X is picked up
                            PopUpPanel.GetComponentInChildren<TextMeshProUGUI>().text = ingredient.title + "\n\n Mehr Info im Questlog (Q)";
                            PopUpPanel.SetActive(true);   
                            if(isPaused)
                            {
                                Time.timeScale = 0;
                            }
                            StartCoroutine(disable_PopUpPanelPanel());
                        } 
                        if(item_id == 100)
                        {
                            Destroy(gameObject);
                            PlayerManager.instance.ChangeScore(almondValue);
                        }
                        
                    }
                Physics2D.IgnoreCollision(collision, GetComponent<Collider2D>());    
                }
            }
            _triggered = true;
        }
    }


    IEnumerator disable_PopUpPanelPanel()
    {
        yield return new WaitForSeconds(3);
        PopUpPanel.SetActive(false);
        // Destroy GameObject with the PickUp script after WaitForSeconds(3)
        Destroy(gameObject); 
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

    //   
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
}
