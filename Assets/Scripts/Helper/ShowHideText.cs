using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowHideText : MonoBehaviour
{
    public ItemDatabase itemDatabase;
    public GameObject itemDB;
    public GameObject DescList;
    

    public Button myButton;
    // this script adds an onlick event to a button in a prefab
     void Awake()
    {
        Button myButton = this.gameObject.GetComponent<Button>();
        Debug.Log(myButton);  
        myButton.onClick.AddListener((UnityEngine.Events.UnityAction) this.OnClick);
        itemDB = GameObject.Find("ItemDatabase");  
        
        Debug.Log("Button in Questlog Entry createded on Awake");  
    }

    public void OnClick()
    {
        
        // cant put object into Awake as it is not active from start on
        DescList = GameObject.Find("DescList");
        Button myButton = this.gameObject.GetComponent<Button>();
        // GetComponentInChildren<TextMeshProUGUI>().text = ingredient title
        Item ingredient = itemDB.GetComponent<ItemDatabase>().GetItemByTitle(myButton.GetComponentInChildren<TextMeshProUGUI>().text);
        DescList.GetComponentInChildren<TextMeshProUGUI>().text = ingredient.description;
    }
}
