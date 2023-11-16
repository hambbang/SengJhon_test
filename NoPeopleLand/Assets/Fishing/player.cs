using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{


    // Update is called once per frame
    public class PlayerMovement : MonoBehaviour
    {
        public float moveSpeed = 5f; // �÷��̾� �̵� �ӵ�

        private Rigidbody2D rb; // �Ǵ� Rigidbody�� ����Ϸ��� 3D ������Ʈ����

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>(); // �Ǵ� GetComponent<Rigidbody>()�� ����Ϸ��� 3D ������Ʈ����
        }

        private void Update()
        {
            // �÷��̾��� �Է��� ����
            float horizontalInput = Input.GetAxis("Horizontal");

            // �÷��̾� �̵�
            Vector2 movement = new Vector2(horizontalInput * moveSpeed, 0);
            rb.velocity = movement; // 2D ������Ʈ���� Rigidbody2D�� ����Ϸ���
                                    // rb.velocity = new Vector3(horizontalInput * moveSpeed, 0, 0); // 3D ������Ʈ���� Rigidbody�� ����Ϸ���
        }
    }
}
