using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroToMainMenu : MonoBehaviour
{
    //////////////////////////////////
    public void Update()
    {
        StartCoroutine("Wait");
    }
 
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void LoadOnClick()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);  
    }

}
