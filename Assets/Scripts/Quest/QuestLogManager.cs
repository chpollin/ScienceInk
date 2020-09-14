using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestLogManager : MonoBehaviour
{
    public GameObject questLogPanel;
    public GameObject closeButton;
    public ItemDatabase itemDatabase;

    public GameObject ingredientEntry;
    public GameObject ingredientList;
    public GameObject ingredientPrefab_Entry;
    
    public GameObject ingredientDescription;
    public GameObject ingredientDescriptionList;
    public GameObject ingredientPrefab_Description;

    private bool questLogPanelOn = false;

    void CloseButton(){
        Debug.Log("test");
        closeButton.SetActive(false);
        closeButton.SetActive(false);
    }    

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
           if(questLogPanelOn)
           {
               questLogPanel.SetActive(false);
                questLogPanelOn = false;
           }
           else
           {
            questLogPanel.SetActive(true);
            questLogPanelOn = true;
            Debug.Log(questLogPanelOn);
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

        ingredientDescription = Instantiate(ingredientPrefab_Description);
        ingredientDescription.transform.SetParent(ingredientDescriptionList.transform);

        // add text to gameobjects
        ingredientEntry.GetComponent<TextMeshProUGUI>().text =  ingredient.title;
        ingredientDescription.GetComponent<TextMeshProUGUI>().text =  ingredient.description;

        //Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        //text.font = ArialFont;
        //text.material = ArialFont.material;
 

    }    


}
