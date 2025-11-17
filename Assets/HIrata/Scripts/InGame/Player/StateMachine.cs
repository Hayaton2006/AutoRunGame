using System;
using UnityEngine;

public abstract class State
{
    public abstract void Enter();
    public abstract void Update();
    public abstract void Exit();
    public abstract bool Cantransition(Type currentStateType);
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

    public void ChangeState(State newstate)
    {
        if (newstate.Cantransition(currentState.GetType()))
        {
            currentState.Exit();
            currentState = newstate;
            currentState.Enter();
        }
    }
}
