using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLM : MonoBehaviour
{
    public RandomA [] round1=new RandomA [5];
    public RandomA [] round2=new RandomA [7];
    public RandomA [] round3=new RandomA [10];
    public static int randi;
    void Start()
    {
        
    }

    void Update()
    {
        if (RoundM.nowRound == 1) { 
            if ((randi==0 || !round1[randi-1].gameObject.activeSelf) && !Timer.gameOver)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (round1[randi].RNumber == 1)
                    {
                        round1[randi].gameObject.SetActive(false);
                        randi++;
                    }
                    else
                        Timer.gameOver = true;
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    if (round1[randi].RNumber == 2)
                    {
                        round1[randi].gameObject.SetActive(false);
                        randi++;
                    }
                    else
                        Timer.gameOver = true;
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (round1[randi].RNumber == 3)
                    {
                        round1[randi].gameObject.SetActive(false);
                        randi++;
                    }
                    else
                        Timer.gameOver = true;
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    if (round1[randi].RNumber == 4)
                    {
                        round1[randi].gameObject.SetActive(false);
                        randi++;
                    }
                    else
                        Timer.gameOver = true;
                }
            }
            
        }
        if (RoundM.nowRound == 2)
        {
            if ((randi == 0 || !round2[randi - 1].gameObject.activeSelf) && !Timer.gameOver)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (round2[randi].RNumber == 1)
                    {
                        round2[randi].gameObject.SetActive(false);
                        randi++;
                    }
                    else
                        Timer.gameOver = true;
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    if (round2[randi].RNumber == 2)
                    {
                        round2[randi].gameObject.SetActive(false);
                        randi++;
                    }
                    else
                        Timer.gameOver = true;
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (round2[randi].RNumber == 3)
                    {
                        round2[randi].gameObject.SetActive(false);
                        randi++;
                    }
                    else
                        Timer.gameOver = true;
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    if (round2[randi].RNumber == 4)
                    {
                        round2[randi].gameObject.SetActive(false);
                        randi++;
                    }
                    else
                        Timer.gameOver = true;
                }
            }
        }
        if (RoundM.nowRound == 3)
        {
            if ((randi == 0 || !round3[randi - 1].gameObject.activeSelf) && !Timer.gameOver)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (round3[randi].RNumber == 1)
                    {
                        round3[randi].gameObject.SetActive(false);
                        randi++;
                    }
                    else
                        Timer.gameOver = true;
                }
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    if (round3[randi].RNumber == 2)
                    {
                        round3[randi].gameObject.SetActive(false);
                        randi++;
                    }
                    else
                        Timer.gameOver = true;
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    if (round3[randi].RNumber == 3)
                    {
                        round3[randi].gameObject.SetActive(false);
                        randi++;
                    }
                    else
                        Timer.gameOver = true;
                }
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    if (round3[randi].RNumber == 4)
                    {
                        round3[randi].gameObject.SetActive(false);
                        randi++;
                    }
                    else
                        Timer.gameOver = true;
                }
            }
        }
    }
}
