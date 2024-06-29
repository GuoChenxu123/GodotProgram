using Godot;
using System;

public partial class State : Node,IDisposable
{
	protected object owner;
    public virtual void SetOwner(object owner)
    {
        this.owner = owner;
    }
    public virtual void Enter()
    {
        // 进入状态时的逻辑
    }

    public virtual void Execute(float delta)
    {
        // 每帧执行的逻辑
    }
    public virtual void Execute()
    {
        // 每帧执行的逻辑
    }
    public virtual void Exit()
    {
        // 退出状态时的逻辑
    }

    public virtual void Dispose()
    {
        // 释放资源
    }
    public virtual string GetName()
    {
        // 获取状态的名称
        return "Unknown State";
    }
}
