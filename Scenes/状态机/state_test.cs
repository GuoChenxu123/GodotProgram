using Godot;
using System;

public partial class state_test : Node2D
{
	private StateMachine stateMachine;
	private think _think;
	private left _left;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        _think  = new think();
		_think.SetOwner(this);
        _left = new left();
		_left.SetOwner(this);
        stateMachine = new StateMachine(_think);

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		stateMachine.Update((float)delta);
	}
}
