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
        Debug.Log("����");
        //�ǰݸ��
        //���Ȯ��
    }
}
