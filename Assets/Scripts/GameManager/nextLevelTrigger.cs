﻿using System.Collections;
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
    GameObject NotAllIngredientsFoundPanel;

    void Start()
    {
        NotAllIngredientsFoundPanel = GameObject.Find("NotAllIngredientsFound");
        NotAllIngredientsFoundPanel.SetActive(false);

    }

    //////////////////////////////
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
    
        if(Ingredients.transform.childCount == 0)
        {
            //SceneManager.LoadScene(newLevel);
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1) );
        }
        else
        {
            NotAllIngredientsFoundPanel.SetActive(true);
            StartCoroutine(disable_NotAllIngredientsFoundPanel());
            
        }
        //gameManager.CompleteLevel();
    }

    IEnumerator disable_NotAllIngredientsFoundPanel()
    {
        Debug.Log("Ich habe noch nicht alle Zutaten gefunden. Es fehlen noch " + Ingredients.transform.childCount + " Zutaten");
        yield return new WaitForSeconds(5);
        NotAllIngredientsFoundPanel.SetActive(false);
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
