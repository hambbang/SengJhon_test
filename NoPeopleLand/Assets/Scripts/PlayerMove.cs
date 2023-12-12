using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Animator ani;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            ani.SetBool("isMove", true);
            UpdateScale(new Vector3(-0.15f, 0.15f));
        }
        else if (Input.GetKey(KeyCode.A))
        {
            ani.SetBool("isMove", true);
            UpdateScale(new Vector3(0.15f, 0.15f));
        }
        else
        {
            ani.SetBool("isMove", false);
        }
    }

    void UpdateScale(Vector3 scale)
    {
        transform.localScale = scale;
    }
}
