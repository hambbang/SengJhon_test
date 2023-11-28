using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class RoundM : MonoBehaviour
{
    public GameObject round1;
    public GameObject round2;
    public GameObject round3;
    public GameObject lastArrow1;
    public GameObject lastArrow2;
    public GameObject lastArrow3;
    public Text inform;
    public GameObject informB;
    public static int nowRound=0;
    bool used=false;
    public static bool clear=false;//임시로 타임스똡에도 씀
    void Start()
    {
       
    }
    void Update()
    {
        if (Timer.gameOver)
        {
            informB.gameObject.SetActive(true);
            inform.text = "Game over!";
        }
        if (nowRound == 0 && !used)
        {
            StartCoroutine(R1Start());
        }
        if (!lastArrow1.activeSelf&&nowRound==1)
            used = false;
        else if (!lastArrow2.activeSelf && nowRound == 2)
            used = false;
        else if (!lastArrow3.activeSelf && nowRound == 3)
            used = false;
        if (nowRound==1&&!used) //if 한번 실행되면 다시 실행 안되게 할 수 없나
        {
            StartCoroutine(R1to2());
        }
        if (nowRound==2&&!used)
        {
            StartCoroutine(R2to3());
        }
        if (nowRound==3&&!used)
        {
            round3.SetActive(false);
            informB.gameObject.SetActive(true);
            inform.text = "Clear!";
            clear = true;

        }
    }
    IEnumerator R1Start() {
        inform.text = "Round1";
        nowRound = 1;
        RandomLM.randi = 0;
        used = true;
        clear = true;
        round1.SetActive(true);
        yield return new WaitForSeconds(2f);
        informB.gameObject.SetActive(false);
        clear = false;
    }
    IEnumerator R1to2() {
        nowRound=2;
        RandomLM.randi = 0;
        Timer.CTimeBar = 0;
        used = true;
        clear = true;
        round1.SetActive(false);
        informB.gameObject.SetActive(true);
        inform.text = "Round2";
        round2.SetActive(true);
        yield return new WaitForSeconds(2f);
        clear = false;
        informB.gameObject.SetActive(false);
    }
    IEnumerator R2to3() {
        nowRound=3;
        used = true;
        RandomLM.randi = 0;
        Timer.CTimeBar = 0;
        round2.SetActive(false);
        clear = true;
        informB.gameObject.SetActive(true);
        inform.text = "Round3";
        round3.SetActive(true);
        yield return new WaitForSeconds(2f);
        clear=false;
        informB.gameObject.SetActive(false);
    }
}
