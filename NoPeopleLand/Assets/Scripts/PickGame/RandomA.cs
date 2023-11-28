using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomA : MonoBehaviour
{
    public int RNumber;
    void Start()
    {   
        RNumber = Random.Range(1, 5);
        switch (RNumber) {
            case 1:
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case 2:
                transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
            case 3:
                transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case 4:
                transform.rotation = Quaternion.Euler(0, 0, 270);
                break;
        }
    }

    void Update()
    {
    }
}