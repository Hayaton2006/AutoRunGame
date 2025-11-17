using System;
using UnityEngine;

public partial class Player
{
    class MoveState : State
    {
        readonly Transform transform;
        readonly float moveSpeed;

        public MoveState(Transform transform, float moveSpeed)
        {
            this.transform = transform;
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
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = new Vector3(x, 0, z);
            transform.Translate(move * moveSpeed * Time.deltaTime, Space.World);
        }
    }
}
