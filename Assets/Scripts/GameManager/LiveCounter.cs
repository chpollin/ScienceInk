using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class LiveCounter : MonoBehaviour
{
    //public GameObject health1, health2, health3, gameOver;
    public GameObject health1, health2, health3;
    public static int health;
    public GameObject gameOverPanel;
    public GameManager gameManager;

    void Start()
    {
        health = 3;
        health1.gameObject.SetActive(true);
        health2.gameObject.SetActive(true);
        health3.gameObject.SetActive(true);
    }

    void Update()
    {
        if (health > 3)
            health = 3;

        switch (health)
        {
            case 3:
                health1.gameObject.SetActive(true);
                health2.gameObject.SetActive(true);
                health3.gameObject.SetActive(true);
                break;
            case 2:
                health1.gameObject.SetActive(true);
                health2.gameObject.SetActive(true);
                health3.gameObject.SetActive(false);
                break;
            case 1:
                health1.gameObject.SetActive(true);
                health2.gameObject.SetActive(false);
                health3.gameObject.SetActive(false);
                break;
            case 0:
                health1.gameObject.SetActive(false);
                health2.gameObject.SetActive(false);
                health3.gameObject.SetActive(false);
                // end game
                gameOverPanel.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;

        }

    }
        // Start is called before the first frame update
   /*     void OnTriggerEnter2D(Collider2D col)
    {
        GameCOntrolsScript.health += 1;
    }*/

   
}
