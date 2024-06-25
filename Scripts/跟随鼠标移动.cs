using Godot;
using System;

public partial class 跟随鼠标移动 : CharacterBody2D
{
	public const float Speed = 300.0f;


	public override void _PhysicsProcess(double delta)
	{
        //GlobalPosition 和 GetGlobalMousePosition() 是 Godot 中用于获取全局位置和鼠标全局位置的方法。
        if (GlobalPosition.DistanceTo(GetGlobalMousePosition()) < 10)
            return;
        //Normalized() 方法用于将向量归一化。
        Vector2 direction = (GetGlobalMousePosition() - GlobalPosition).Normalized();
        //Angle() 方法用于获取向量的角度。
        Rotation = direction.Angle();
        if (direction != Vector2.Zero)
        {
            Velocity = direction * Speed;
        }
        else
        {
            Velocity = Vector2.Zero;
        }
        //MoveAndSlide() 是 Godot 中用于移动和滑动的方法。
        MoveAndSlide();
    }
}


