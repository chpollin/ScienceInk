﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroCutscenetoLevel1 : MonoBehaviour
{
    //////////////////////////////////
    public void Update()
    {
        StartCoroutine("Wait");
    }
 
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(25f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void LoadOnClick()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);  
    }

}
