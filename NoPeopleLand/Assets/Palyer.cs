using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palyer : MonoBehaviour
{
    public int maxHp = 100;
    public int curHp = 100;
    public int attactDamage = 100;
    

    public Monster enemy;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("АјАн");
            enemy.GetDamage(attactDamage);
        }
    }
}
