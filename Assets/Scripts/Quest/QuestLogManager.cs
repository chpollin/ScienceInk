using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuestLogManager : MonoBehaviour
{
    public GameObject questLogPanel;
    public ItemDatabase itemDatabase;
    private GameObject ingredientEntry;
    public GameObject ingredientList;
    public GameObject ingredientPrefab_Entry;
    
    private bool questLogPanelOn = false;

    // QuestLogPanel 
    void Start()
    {
        questLogPanel.SetActive(false);
    }

    // if Q is pressed open QuestLogPanel
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            if(questLogPanel.activeSelf) 
            {
                questLogPanelOn = true;
            }
            if(questLogPanelOn)
            {
                questLogPanel.SetActive(false);
                questLogPanelOn = false;
                Time.timeScale = 1;
            }
           else
           {
            questLogPanel.SetActive(true);
            questLogPanelOn = true;
            Time.timeScale = 0;
           }
           
        }
    }

    // addQuest
    public void addIngredientToQuest(int item_id)
    {
        // get ingredient from itemDatabase via pickup.cs
        Item ingredient = itemDatabase.GetItemByID(item_id);

        // create new ingredientEntry and add it to ingredientList
        ingredientEntry = Instantiate(ingredientPrefab_Entry);
        ingredientEntry.transform.SetParent(ingredientList.transform);

        ingredientEntry.GetComponentInChildren<TextMeshProUGUI>().text =  ingredient.title;
        ingredientEntry.GetComponentInChildren<Image>().sprite = ingredient.icon;
    }  

}
