using System;
using UnityEngine;

public partial class Player
{
    class ForwardState : State
    {
        readonly Rigidbody rigidbody;
        readonly float moveSpeed;

        public ForwardState(Rigidbody rigidbody, float moveSpeed)
        {
            this.rigidbody = rigidbody;
            this.moveSpeed = moveSpeed;
        }

        public override bool CanTransition(Type currentStateType)
        {
            return true;
        }

        public override void Enter()
        {
         
        }

        public override void Exit()
        {
          
        }

        public override void Update()
        {
            Vector3 move = new Vector3(0, 0, 1).normalized;
            rigidbody.linearVelocity = move * moveSpeed;
        }
    }
}