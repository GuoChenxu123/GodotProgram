using Godot;
using System;

public partial class left : State
{
    public override void Dispose()
    {
        base.Dispose();
    }

    public override void Enter()
    {
        GD.Print("enter left state");
        if(this.owner is state_test stateTest && stateTest.animPlayer!= null)
        {
            stateTest.animPlayer.Play("left");
        }
    }

    public override void Execute(float delta)
    {
        if(owner is state_test stateTest)
        {
            stateTest.Position += new Vector2(-100 * delta, 0);
        }
    }

    public override void Execute()
    {
        base.Execute();
    }

    public override void Exit()
    {
        GD.Print("exit left state");
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
