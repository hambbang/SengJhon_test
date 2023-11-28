using JetBrains.Annotations;
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
        bool on = false;
        void Update ()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                on = true;
                transform.Translate(new Vector3(0.01f, 0, 0));
                
            }
            else
            {
                on = false;
            }

        }

        void OnTriggerStay2D(Collider2D collision)
        {
           if(collision.gameObject.name == "FishingWall" && on)
            {
                fishing.SetActive(true);

            }
            
        }
         
        









    }
}