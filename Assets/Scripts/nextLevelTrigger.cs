using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelTrigger : MonoBehaviour
{
    [SerializeField] private string newLevel;
    
    public GameManager gameManager;


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(newLevel);
        }
        //gameManager.CompleteLevel();
    }
}
