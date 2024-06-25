using Godot;
using System;

public partial class DissolveTest : Node2D
{
	private Sprite2D _sprite2D;

	private HSlider _slider;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_sprite2D = GetNode<Sprite2D>("Icon");
		_slider = GetNode<HSlider>("HSlider");
		_slider.ValueChanged += OnSliderValueChanged;


	}

    private void OnSliderValueChanged(double value)
    {
        (_sprite2D.Material as ShaderMaterial ).SetShaderParameter("DissolveParameter", value); 
    }
}
