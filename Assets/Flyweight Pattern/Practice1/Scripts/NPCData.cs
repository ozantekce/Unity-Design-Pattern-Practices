using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace FlyweightPattern.Practice1
{
    [CreateAssetMenu(fileName = "npcdata", menuName = "NPC Data", order = 51)]
    public class NPCData : ScriptableObject
    {

        [SerializeField]
        private string _name;
        [SerializeField]
        private Material _material;

        public string Name { get => _name; set => _name = value; }
        public Material Material { get => _material; set => _material = value; }
    }

}
