using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelTrigger : MonoBehaviour
{
    //[SerializeField] private string newLevel;
    public Animator transition;
    private bool allIngredientsFound = false;
    public float transitionTime = 1f;
    public GameManager gameManager;

    //////////////////////////////
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
    
        if(allIngredientsFound)
        {
            //SceneManager.LoadScene(newLevel);
            StartCoroutine( LoadLevel(SceneManager.GetActiveScene().buildIndex+1) );
        }
        else
        {
            Debug.Log("Ich habe noch nicht alle Zutaten gefunden");
        }
        //gameManager.CompleteLevel();
    }

    //////////////////////////////
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        // just wait a bit
        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
