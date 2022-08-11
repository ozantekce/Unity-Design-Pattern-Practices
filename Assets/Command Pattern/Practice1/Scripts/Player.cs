using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.Practice1
{
    public class Player : MonoBehaviour
    {
        public float acceleration, maxSpeed, jumpPower;

        [HideInInspector]
        public Rigidbody rigidbody;
        
        [HideInInspector]
        public Vector3 movement;
        public bool jump;
        public float delayToJump;


        private Command moveCommand,jumpCommand;

        void Start()
        {
            rigidbody = gameObject.AddComponent<Rigidbody>();
            rigidbody.constraints = RigidbodyConstraints.FreezeRotationX
                |RigidbodyConstraints.FreezeRotationZ;


            moveCommand = new MoveCommand();
            jumpCommand = new JumpCommand();

        }

        void Update()
        {
            ReadMovementInput();
            moveCommand.Execute(this);
            jumpCommand.Execute(this);
        }


        private void ReadMovementInput()
        {

            jump = false;
            movement = Vector3.zero;
            if (Input.GetAxis("Horizontal") > 0)
            {
                movement += Vector3.right;
            }
            if (Input.GetAxis("Horizontal") < 0)
            {
                movement += Vector3.left;
            }
            if (Input.GetAxis("Vertical") > 0)
            {
                movement += Vector3.forward;
            }
            if (Input.GetAxis("Vertical") < 0)
            {
                movement += Vector3.back;
            }

            if (Input.GetAxis("Jump") > 0)
            {
                jump = true;
            }

        }

    }


}
