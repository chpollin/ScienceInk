using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelTrigger : MonoBehaviour
{
    //[SerializeField] private string newLevel;
    public Animator transition;
    public float transitionTime = 1f;
    public GameManager gameManager;
    public GameObject Ingredients;

    //////////////////////////////
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
    
        if(Ingredients.transform.childCount == 0)
        {
            //SceneManager.LoadScene(newLevel);
            StartCoroutine( LoadLevel(SceneManager.GetActiveScene().buildIndex+1) );
        }
        else
        {

            Debug.Log("Ich habe noch nicht alle Zutaten gefunden. Es fehlen noch " + Ingredients.transform.childCount + " Zutaten");
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
