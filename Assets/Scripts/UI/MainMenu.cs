using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame ()
   {
       Debug.Log("Menu: Play Game");
       SceneManager.LoadScene("cutscene_intro");
   }

    public void QuitGame ()
   {
       Debug.Log("Menu: Quit Game");
       Application.Quit();
   }

    public void RestartGame ()
   {
       Debug.Log("Menu: Restart Game");
       SceneManager.LoadScene("Level_1");
   }
}
