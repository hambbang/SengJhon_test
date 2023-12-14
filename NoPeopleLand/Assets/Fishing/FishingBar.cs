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
            if (Input.GetKeyUp(KeyCode.F))
            {
                RaycastHit2D[] hit = Physics2D.BoxCastAll(new Vector2(transform.position.x, transform.position.y), new Vector2(0.15f, 0.15f), 0f, Vector2.zero);
                // hit RaycastHit 자료형의 변수 생성 = collider 의 정보를 받아 출력 ,함수
                for (int i = 0; i < hit.Length; i++)
                {
                    RaycastHit2D ok = hit[i];
                    //배열에 있는 정보를 단일 자료형 ok의 저장

                    if (ok.collider == FishingWall)//ok의 collider 형으로 변환, 비교
                    {
                        minigames.hookProgress = 0;
                        minigames.failTimer = 10f;
                        minigames.stop = false;
                        minigames.pause = false;
                        fishing.SetActive(true);

                        fishing.gameObject.SetActive(true);
                    }
                }
            }
          
                

                
            
        }
        
        void OnTriggerStay2D(Collider2D collision)
        {
            
            
        }


        
                

 





    }
}