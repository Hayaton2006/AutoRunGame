using System;
using UnityEngine;

public partial class Enemy
{
    class IdleState : State
    {
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
            
        }
    }
}

