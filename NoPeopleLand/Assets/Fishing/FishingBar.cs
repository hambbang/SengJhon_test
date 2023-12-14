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
                        //FishingWall= 오브젝트 boxcast(플레이어 위치 x,y,z/감지범위(0.15f,0.15f,1)/2 회전x
                        //같을시 아래코드 실행
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