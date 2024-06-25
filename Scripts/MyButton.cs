using Godot;
using System;

public partial class MyButton : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        //动态实例化Sprite2D节点
        Sprite2D sprite2D = this.GetTree().CurrentScene.GetNode<Sprite2D>("Sprite2D");
		//动态链接信号
		this.Connect("button_up", new Callable(sprite2D , "changeRotation"));
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	
}
