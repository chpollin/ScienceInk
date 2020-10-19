using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowHideText : MonoBehaviour
{
    public Button myButton;
    // this script adds an onlick event to a button in a prefab
     void Awake()
    {
        Button myButton = this.gameObject.GetComponent<Button>();
        myButton.onClick.AddListener ((UnityEngine.Events.UnityAction) this.OnClick);
    }

    public void OnClick()
    {
        Button myButton = this.gameObject.GetComponent<Button>();
        Debug.Log(myButton.GetComponentInChildren<TextMeshProUGUI>().text);
    }
}
