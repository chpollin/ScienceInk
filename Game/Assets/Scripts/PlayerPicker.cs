using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPicker : MonoBehaviour
{
    private float objects = 0;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "ObjecttoPick")
        {
            objects ++;
            Destroy(other.gameObject);
            Debug.Log("Collected " + objects + " Objects");
        }

    }


}
