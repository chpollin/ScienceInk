﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollText : MonoBehaviour
{
    public bool repeat;
    public float scrollSpeed;
    public GameObject textToScroll;
    
    //We want to store the world position of the
    //canvas to the screen as a rect.
    private Rect screen;

    public void Start()
    {
        // Get the parent canvas of the current game object
        Canvas menuCanvas = gameObject.GetComponentInParent<Canvas>();

        // Grab the tranform position as a world point
        // First zero then the width and height
        Vector3 canvasWorldPointZero = menuCanvas.worldCamera.ScreenToWorldPoint(Vector3.zero);
        Vector3 canvasWorldPointWH = menuCanvas.worldCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height));

        // Draw our rectangle. First the position from canvasWorldPointZero then to the width and height.
        screen = new Rect(canvasWorldPointZero,
            new Vector2(canvasWorldPointWH.x - canvasWorldPointZero.x, canvasWorldPointWH.y - canvasWorldPointZero.y));

    }
    public void Update()
    {
        //Create an array of four values to store our text corners
        Vector3[] wc = new Vector3[4];

        // Grab the corners of our text rect tranform. 
        textToScroll.GetComponent<RectTransform>().GetWorldCorners(wc);

        // Create a rectangle based on our text to scroll game object
        // the same as we did above
        Rect rect = new Rect(wc[0].x, wc[0].y, wc[2].x - wc[0].x, wc[2].y - wc[0].y);


        // Check if it overlaps the canvas rect using the overlap function
    
        // Move the text up
        textToScroll.transform.Translate(Vector3.up * (scrollSpeed * Time.deltaTime));
        
    }
}