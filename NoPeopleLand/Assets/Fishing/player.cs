using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{


    // Update is called once per frame
    public class PlayerMovement : MonoBehaviour
    {
        public float moveSpeed = 5f; // 플레이어 이동 속도

        private Rigidbody2D rb; // 또는 Rigidbody를 사용하려면 3D 프로젝트에서

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>(); // 또는 GetComponent<Rigidbody>()를 사용하려면 3D 프로젝트에서
        }

        private void Update()
        {
            // 플레이어의 입력을 감지
            float horizontalInput = Input.GetAxis("Horizontal");

            // 플레이어 이동
            Vector2 movement = new Vector2(horizontalInput * moveSpeed, 0);
            rb.velocity = movement; // 2D 프로젝트에서 Rigidbody2D를 사용하려면
                                    // rb.velocity = new Vector3(horizontalInput * moveSpeed, 0, 0); // 3D 프로젝트에서 Rigidbody를 사용하려면
        }
    }
}
