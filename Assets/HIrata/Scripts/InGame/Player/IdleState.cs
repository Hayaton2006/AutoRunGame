using System;

public partial class Player
{
    class IdleState : State
    {
        public override bool Cantransition(Type currentStateType)
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