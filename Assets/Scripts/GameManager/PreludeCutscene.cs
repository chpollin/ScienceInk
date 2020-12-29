using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreludeCutscene : MonoBehaviour
{
    //////////////////////////////////
    public void Update()
    {
        StartCoroutine("Wait");
    }
 
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(60f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
     }

}
