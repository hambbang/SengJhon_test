using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.WebRequestMethods;

public class Timer : MonoBehaviour
{
    float fullTimeBar=68;
    public static float CTimeBar = 0;
    float currentWidth;
    public Image timeBar;
    public static bool gameOver=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CTimeBar<68&&!RoundM.clear&&!gameOver)
            CTimeBar += 0.1f;
        currentWidth = fullTimeBar-CTimeBar;
        RectTransform rectTransform = timeBar.rectTransform;
        rectTransform.sizeDelta = new Vector2(currentWidth , rectTransform.sizeDelta.y);
        if (CTimeBar >= 68)
        {
            Debug.Log("Time's up!");
            gameOver = true;
        }
    }
}
