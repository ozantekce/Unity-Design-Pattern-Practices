using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CommandPattern.Practice1
{
    public abstract class Command
    {

        public abstract void Execute(Player player);

    }


    public class MoveCommand : Command
    {

        public override void Execute(Player player)
        {
            
            player.rigidbody.AddForce(player.movement*Time.deltaTime*player.acceleration
                ,ForceMode.Impulse);

            Vector2 velocityXZ = new Vector2(player.rigidbody.velocity.x, player.rigidbody.velocity.z);

            if(velocityXZ.magnitude > player.maxSpeed)
            {
                velocityXZ = velocityXZ.normalized*player.maxSpeed;
                player.rigidbody.velocity = new Vector3(velocityXZ.x, player.rigidbody.velocity.y,velocityXZ.y);
            }


        }

    }


    public class JumpCommand : Command
    {

        private float lastJumpTime;
        public override void Execute(Player player)
        {



            if(player.jump && ElapsedTime() > player.delayToJump && OnGround(player))
            {
                Debug.Log("input : " + player.jump);
                Debug.Log("elapsed time : " + ElapsedTime());
                Debug.Log("onGround : " + OnGround(player));
                lastJumpTime = Time.time;
                player.rigidbody.AddForce(Vector3.up * player.jumpPower
                    ,ForceMode.VelocityChange);
            }



        }

        private float ElapsedTime()
        {
            return Time.time - lastJumpTime;
        }

        private bool OnGround(Player player)
        {

            RaycastHit hit;
            Physics.Raycast(player.transform.position,Vector3.down,out hit,1.5f);
            
            return hit.collider !=null;

        }

    }




}
