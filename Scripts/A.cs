using Godot;
using System;

public partial class A : Sprite2D
{
	//声明信号
	[Signal]
	public delegate void MySignalEventHandler();
	public override void _Ready()
	{

	}
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("左"))
		{
			//发射信号
			EmitSignal("MySignal");
		}
	}
}
