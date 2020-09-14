using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestLogManager : MonoBehaviour
{
    public GameObject questLogPanel;
    public GameObject closeButton;
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
    public void addIngredientToQuest(){
        Debug.Log("Ingredient added to the QuestLog: ");
    }    


}
