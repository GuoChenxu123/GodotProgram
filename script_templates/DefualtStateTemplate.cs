using Godot;
using System;

public partial class DefualtStateTemplate : State
{
    public override void Dispose()
    {
        base.Dispose();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Execute(float delta)
    {
        base.Execute(delta);
    }

    public override void Execute()
    {
        base.Execute();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override string GetName()
    {
        return base.GetName();
    }

    public override void SetOwner(object owner)
    {
        base.SetOwner(owner);
    }
}
