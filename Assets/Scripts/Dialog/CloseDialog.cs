using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDialog : MonoBehaviour
{
    public GameObject dialogPanel;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(dialogPanel.activeSelf == true)
        {
            dialogPanel.SetActive(false);

        } 
    }
}
