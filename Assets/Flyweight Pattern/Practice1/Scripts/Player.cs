using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace FlyweightPattern.Practice1
{

    public class Player : MonoBehaviour
    {
        private CharacterController _characterController;
        void Start()
        {
            _characterController = GetComponent<CharacterController>();
        }


        void Update()
        {

            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            move = transform.TransformDirection(move);

            _characterController.Move(move*Time.deltaTime*10f);

            transform.Rotate(0, (Input.GetAxis("Mouse X") * 200f * Time.deltaTime), 0, Space.World);

        }




    }

}

