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
        //collision.gameObject.name == "FishingWall" && 
        









    }
}