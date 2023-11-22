using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomA : MonoBehaviour
{
    int RNumber;
    public GameObject pariorArrow=null;
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
        Debug.Log(RNumber);
    }

    void Update()
    {
        if (pariorArrow == null||!pariorArrow.activeSelf) { 
            if(Input.GetKeyDown(KeyCode.UpArrow)&&RNumber==1)
                gameObject.SetActive(false);
            if(Input.GetKeyDown(KeyCode.LeftArrow)&&RNumber==2)
                gameObject.SetActive(false);
            if(Input.GetKeyDown(KeyCode.DownArrow)&&RNumber==3)
                gameObject.SetActive(false);
            if (Input.GetKeyDown(KeyCode.RightArrow) && RNumber == 4)
                gameObject.SetActive(false);
        }
    }
}
