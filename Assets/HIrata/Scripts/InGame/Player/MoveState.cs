using System;
using UnityEngine;
using UnityEngine.InputSystem;

public partial class Player
{
    class MoveState : State
    {
        readonly Rigidbody rigidbody;
        readonly float moveSpeed;

        public MoveState(Rigidbody rigidbody, float moveSpeed)
        {
            this.rigidbody  = rigidbody;
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
            float x = 0f;
            float z = 0f;

            if (Keyboard.current != null)
            {
                if (Keyboard.current.wKey.isPressed) z = 1;
                if (Keyboard.current.sKey.isPressed) z = -1;
                if (Keyboard.current.aKey.isPressed) x = -1;
                if (Keyboard.current.dKey.isPressed) x = 1;
            }

            Vector3 move = new Vector3(x, 0, z).normalized;
            rigidbody.linearVelocity = move * moveSpeed;
        }
    }
}
