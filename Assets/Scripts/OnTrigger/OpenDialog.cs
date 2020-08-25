using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDialog : MonoBehaviour
{
    public GameObject dialogPanel;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Debug.Log("trigger");
            if(dialogPanel.activeSelf == true)
            {
              Debug.Log("Dialog war noch nciht geschlossen");  
            }
            else
            {
                dialogPanel.SetActive(true);
            }
            
            
        }
    }
}
