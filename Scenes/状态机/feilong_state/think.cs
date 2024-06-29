using Godot;
using System;

public partial class think : State
{
    public override void Dispose()
    {
        base.Dispose();
    }

    public override void Enter()
    {
        GD.Print("进入思考状态");
        GD.Print("enter think state");
        if (this.owner is state_test stateTest && stateTest.animPlayer != null)
        {
            stateTest.animPlayer.Play("defualt");
            //移动

        }
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
        GD.Print("退出思考状态");
    }

    public override string GetName()
    {
        return "think";
    }

    public override void SetOwner(object owner)
    {
        base.SetOwner(owner);
    }
}
