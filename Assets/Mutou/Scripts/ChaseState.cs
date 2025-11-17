using System;
using UnityEngine;

public partial class Enemy
{
    class ChaseState : State
    {
        readonly Transform transform;
        readonly GameObject target;
        readonly float chaseSpeed;

        public ChaseState(Transform transform, GameObject target, float chaseSpeed)
        {
            this.transform = transform;
            this.target = target;
            this.chaseSpeed = chaseSpeed;
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
            transform.LookAt(target.transform);
            transform.position += transform.forward * chaseSpeed;
        }
    }

}