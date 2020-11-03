using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelText : MonoBehaviour
{
    // Level text + Tutorial displayed for 10 seconds than fades out

    void Start()
    {
        StartCoroutine(FadeTextToZeroAlpha(2f, GetComponent<TextMeshProUGUI>())); 
            
    }

    public IEnumerator FadeTextToZeroAlpha(float t, TextMeshProUGUI i)
    {
        yield return new WaitForSeconds(10);

        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }

        yield return new WaitForSeconds(1);

        this.gameObject.SetActive(false);  
    }
}
