using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public GameObject mainMenu;

   public void PlayGame ()
   {
       SceneManager.LoadScene("0_cutscene_prelude");
   }

    public void QuitGame ()
   {
       Application.Quit();
   }

    //////////////////////////////////
    public void RestartLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }

    //////////////////////////////////
    public void BacktoMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    // starts the time again, when scene is reloaded after menu button or player death
    void Awake()
    {
        Time.timeScale = 1;
    }

}
