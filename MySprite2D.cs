using Godot;
using System;

public partial class MySprite2D : Sprite2D
{
	[Export]
	public bool IsRotating = false;
	[Export]
	public bool IsMovingUp = false;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}
	public void changeRotation()
	{
		this.IsRotating =!this.IsRotating;
	}
	public void moveUp()
	{
		this.IsMovingUp =!this.IsMovingUp;
	}
    
    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
		if (IsRotating)
		{
			var rotation = this.RotationDegrees;
			rotation += 10.0f * (float)delta;
			this.RotationDegrees = rotation;
		}
		if (IsMovingUp)
		{
            this.Position = new Vector2(this.Position.X, this.Position.Y + 2.0f);
        }
	}
}
