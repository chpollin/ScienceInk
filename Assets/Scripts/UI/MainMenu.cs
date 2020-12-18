using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
   public void PlayGame ()
   {
       SceneManager.LoadScene("0_cutscene_prelude");
   }

    public void QuitGame ()
   {
       Application.Quit();
   }

    public void RestartGame ()
   {
       SceneManager.LoadScene("Level_1");
   }
}
