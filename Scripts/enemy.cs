﻿using Godot;
using System;

public partial class enemy : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}
	public void test()
	{
		GD.Print($"I am an enemy : {this.Name}");
	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
