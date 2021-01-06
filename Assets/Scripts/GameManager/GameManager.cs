using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false; 

    public float restartDelay = 2f;
    public Vector2 lastCheckPointPos;
    public GameObject MenuPanel;
    private bool MenuPanelOn = false;

     // if Q is pressed open MenuPanel
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(MenuPanel.activeSelf) 
            {
                MenuPanelOn = true;
            }
            if(MenuPanelOn)
            {
                MenuPanel.SetActive(false);
                MenuPanelOn = false;
                Time.timeScale = 1;
            }
           else
           {
            MenuPanel.SetActive(true);
            MenuPanelOn = true;
            Time.timeScale = 0;
           }
           
        }
    }

    //////////////////////////////////
   /* public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }*/




}
