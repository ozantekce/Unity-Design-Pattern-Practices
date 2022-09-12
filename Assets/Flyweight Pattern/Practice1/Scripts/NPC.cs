using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FlyweightPattern.Practice1
{

    public class NPC : MonoBehaviour
    {

        public NPCData data;

        private void Start()
        {
            GetComponentInChildren<Renderer>().material = data.Material;
        }

    }


}
