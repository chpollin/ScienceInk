using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuestLogManager : MonoBehaviour
{
    public GameObject questLogPanel;
    public GameObject closeButton;
    public ItemDatabase itemDatabase;
    private GameObject ingredientEntry;
    public GameObject ingredientList;
    public GameObject ingredientPrefab_Entry;
    
    //private GameObject ingredientDescription;
    //public GameObject ingredientDescriptionList;
    public GameObject ingredientPrefab_Description;
    

    private bool questLogPanelOn = false;

    void CloseButton(){
        closeButton.SetActive(false);
        Time.timeScale = 1;
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
            if(questLogPanel.activeSelf) 
            {questLogPanelOn = true;}
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

        //ingredientDescription = Instantiate(ingredientPrefab_Description);
        //ingredientDescription.transform.SetParent(ingredientDescriptionList.transform);

        // add text to gameobjects
        //ingredientEntry.GetComponent<TextMeshProUGUI>().text =  ingredient.title;
        
        ingredientEntry.GetComponentInChildren<TextMeshProUGUI>().text =  ingredient.title;
        ingredientEntry.GetComponentInChildren<Image>().sprite = ingredient.icon;
        //ingredientEntry.GetComponentInChildren<ShowHideText>();
        

        
        //ingredientDescription.GetComponent<TextMeshProUGUI>().text =  ingredient.description;
        //ingredientDescription.gameObject.tag = "ingredient_desc";
        
        
        //ingredientDescription.SetActive(false);
        //Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        //text.font = ArialFont;
        //text.material = ArialFont.material;
 

    }  

}
