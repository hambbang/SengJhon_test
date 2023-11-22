using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.WebRequestMethods;

public class Timer : MonoBehaviour
{
    float fullTimeBar=68;
    float CTimeBar = 0;
    float currentWidth;
    public Image timeBar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CTimeBar<68)
            CTimeBar += 0.3f;
        currentWidth = fullTimeBar-CTimeBar;
        RectTransform rectTransform = timeBar.rectTransform;
        rectTransform.sizeDelta = new Vector2(currentWidth , rectTransform.sizeDelta.y);
       // Debug.Log(CTimeBar);
        if (CTimeBar <= 0)
        {
            Debug.Log("Time's up!");
        }
    }
}
