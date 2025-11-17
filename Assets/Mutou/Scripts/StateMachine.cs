using System;
using UnityEngine;

public abstract class State
{
    public abstract void Enter();
    public abstract void Update();
    public abstract void Exit();

    public abstract bool CanTransition(Type currentStateType);
}


public class StateMachine
{
    State currentState;

    public StateMachine(State state)
    {
        currentState = state;
        currentState.Enter();
    }

    public void Update()
    {
        currentState.Update();
    }

    public void ChangeState(State newState)
    {
        if (newState.CanTransition(currentState.GetType()))
        {

            currentState.Exit();
            currentState = newState;
            currentState.Enter();

        }
    }

    public Type GetStateType()
    {
        return currentState.GetType();
    }
}
