using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false; 

    public float restartDelay = 1f;
    public Vector2 lastCheckPointPos;




    //////////////////////////////////
    public void BacktoMainMenu()
    {
        gameHasEnded = true;
        SceneManager.LoadScene("Menu");
    }

    //////////////////////////////////
    public void CompleteLevel()
    {
        Debug.Log("Level 1");
    }

    //////////////////////////////////
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    //////////////////////////////////
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
