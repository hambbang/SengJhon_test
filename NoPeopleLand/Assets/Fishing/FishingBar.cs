using JetBrains.Annotations;
using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Fishing
{
    public class FishingBar : MonoBehaviour
    {
       
        public GameObject fishing;
        public BoxCollider2D FishingWall;
        
        void Update ()
        {
            if (Input.GetKey(KeyCode.F))
            {
                    if (FishingWall== Physics.BoxCast(new Vector3(transform.position.x, transform.position.y,
                        transform.position.z),
                        new Vector3(0.15f,0.15f,1) / 2,
                        new Vector3(0, 0, 0)))
                        //FishingWall= ������Ʈ boxcast(�÷��̾� ��ġ x,y,z/��������(0.15f,0.15f,1)/2 ȸ��x
                        //������ �Ʒ��ڵ� ����
                    {

                    minigames.hookProgress = 0;
                    minigames.failTimer = 10f;
                    minigames.stop = false;
                    minigames.pause = false;
                    fishing.SetActive(true);
                }
            }
        }
        
        void OnTriggerStay2D(Collider2D collision)
        {
            
            
        }


        
                

 





    }
}