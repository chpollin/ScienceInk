using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelTrigger : MonoBehaviour
{
    //[SerializeField] private string newLevel;
    public Animator transition;
    public GameManager gameManager;
    public GameObject Ingredients;
    GameObject NotAllIngredientsFoundPanel;
    public Transform kaboom;
    public Transform boilerWithAnimation;
    

    void Start()
    {
        NotAllIngredientsFoundPanel = GameObject.Find("NotAllIngredientsFound");
        NotAllIngredientsFoundPanel.SetActive(false);
        

    }

    //////////////////////////////
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject boiler = GameObject.Find("boiler");
        if(other.CompareTag("Player"))
    
        if(Ingredients.transform.childCount == 0)
        {
            Transform newKaboom = Instantiate(kaboom, boiler.transform.position, Quaternion.identity);
            StartCoroutine(wait(newKaboom));  

            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1) );
        }
        else
        {
            NotAllIngredientsFoundPanel.SetActive(true);
            StartCoroutine(disable_NotAllIngredientsFoundPanel());
            
        }
        //gameManager.CompleteLevel();
    }

    IEnumerator wait(Transform newKaboom)
    {
        GameObject boiler = GameObject.Find("boiler");
        yield return new WaitForSeconds(2f);
       
        //Instantiate(boilerWithAnimation, new Vector3(1 * 2.0F, 0, 0), Quaternion.identity);
        Instantiate(boilerWithAnimation, boiler.transform.position, Quaternion.identity);
        Destroy(newKaboom.gameObject);
        
        Destroy(boiler);
    }

    IEnumerator disable_NotAllIngredientsFoundPanel()
    {
        yield return new WaitForSeconds(6f);
        NotAllIngredientsFoundPanel.SetActive(false);
    }

    //////////////////////////////
    IEnumerator LoadLevel(int levelIndex)
    {
         yield return new WaitForSeconds(5f);
        transition.SetTrigger("Start");

        // just wait a bit
       

        SceneManager.LoadScene(levelIndex);
    }
}
