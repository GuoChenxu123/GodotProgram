using Godot;
using System;

public partial class StateMachine : Node
{
    private State currentState = null;


    public StateMachine(State initialState = null)
    {
        if (initialState != null)
        {
            ChangeState(initialState);
        }
    }
    public void ChangeState(State newState)
    {
        if (currentState != null)
        {
            //退出目前状态
            currentState.Exit();
            currentState.Dispose();
        }
        //赋值新状态
        currentState = newState;
        if (currentState != null)
        {
            //进入新状态
            currentState.Enter();
        }
    }
    public void Update(float delta)
    {
        if (currentState != null)
        {
            currentState.Execute(delta);
        }
    }
    public void Update()
    {
        if (currentState != null)
        {
            currentState.Execute();
        }
    }
    public bool IsState(string stateName)
    {
        if (currentState == null)
        {
            return false;
        }
        return currentState.Name == stateName;
    }
    public bool IsState(Type stateType)
    {
        return currentState != null && currentState.GetType() == stateType;
    }
}
