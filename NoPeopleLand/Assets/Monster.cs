using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monster : MonoBehaviour
{
    int curhp = 100;

    public void GetDamage(int damage)
    {
        curhp -= damage;
        Debug.Log("으악");
        //피격모션
        //사망확인
    }
}
