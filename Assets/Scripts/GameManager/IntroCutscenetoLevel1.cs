using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroCutscenetoLevel1 : MonoBehaviour
{

    public int second = 0;

    //////////////////////////////////
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);  
        }
        StartCoroutine("Wait");
       
    }
 
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(second);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void LoadOnClick()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);  
    }

}
