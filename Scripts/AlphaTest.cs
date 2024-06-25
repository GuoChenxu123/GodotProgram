using Godot;
using System;

public partial class AlphaTest : Node
{
	//获取图片
	private Sprite2D _sprite2D;

	//获取滑块
	private HSlider _hSlider;
	public override void _Ready()
	{
		_sprite2D = GetNode<Sprite2D>("Icon");
		_hSlider = GetNode<HSlider>("HSlider");

        _hSlider.ValueChanged += OnSliderValueChange;
    }

    private void OnSliderValueChange(double value)
    {
		(_sprite2D.Material as ShaderMaterial).SetShaderParameter("AlphaParameter", value);
    }
}
