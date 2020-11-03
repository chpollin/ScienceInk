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
        yield return new WaitForSeconds(20f);
        SceneManager.LoadScene(1);
     }

}