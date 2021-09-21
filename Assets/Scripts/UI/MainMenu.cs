using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public GameObject mainMenu;

    public GameObject creditPanel;


   public void PlayGame()
   {
       SceneManager.LoadScene("0_cutscene_prelude");
   }

    public void QuitGame()
   {
       Application.Quit();
       Debug.Log("Spiel beendet");
   }

    //////////////////////////////////
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }


    //////////////////////////////////
    public void BacktoMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    //////////////////////////////////
    public void ScienceInk()
    {
        Application.OpenURL("https://science-ink.uni-graz.at/de/");
    }


    //////////////////////////////////
    public void Credits()
    {
         creditPanel.SetActive(true);
    }

        public void CloseCredits()
    {
         creditPanel.SetActive(false);
    }

    // starts the time again, when scene is reloaded after menu button or player death
    void Awake()
    {
        Time.timeScale = 1;
    }
    

}
