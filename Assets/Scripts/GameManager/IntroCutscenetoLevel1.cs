using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroCutscenetoLevel1 : MonoBehaviour
{

    public int second = 0;
    public int audio_1_delay = 0;
    public int audio_2_delay = 0;
    public AudioSource audio_1;
    public AudioSource audio_2;
    public AudioSource audio_3;
    public AudioSource audio_4;
    public  GameObject original;
    public  GameObject dialog;
    //////////////////////////////////
    public void Start(){
        audio_1.PlayDelayed(audio_1_delay);
        audio_2.PlayDelayed(audio_2_delay);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);  
        }
        
        StartCoroutine("Wait");
       
    }
 
    IEnumerator Wait()
    {
        
        yield return new WaitForSeconds(second);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void LoadOnClick()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);  
    }

    public void getOriginal()
    {
      dialog.SetActive(false);
      audio_1.Stop();
      audio_2.Stop();
      audio_3.PlayDelayed(1);
      audio_4.PlayDelayed(16);
      original.SetActive(true);
    }

}
