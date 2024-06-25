using Godot;
using System;

public partial class Sprite2DBaseCode : Sprite2D
{
	[Export]
	public Texture2D newtexture;
	double time = 0;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Hello World!");
		//CanvasItem常用属性
		//是否显示
		this.Visible = true;
		//渲染顺序
		this.ZIndex = 10;
		this.ZAsRelative = false;
		//Node2D常用属性
		//位置
		this.Position = new Vector2(500, 500);
		//旋转
		//this.Rotation = 0.1f; //弧度
		//this.RotationDegrees = 30;  //角度
		//缩放
		this.Scale = new Vector2(2, 2);
		//倾斜
		//this.Skew = 30;
		//Sprite常用属性
		//纹理
		//this.Texture = GD.Load<Texture2D>("res://icon.png");
		//锚点左上角
		//this.Centered = false;
		//偏移
		//this.Offset = new Vector2(0, 0);
		//翻转
		//this.FlipH = false;
		//this.FlipV = false;
		//动画
		this.Hframes = 2;//横向帧数
		this.Vframes = 2;//纵向帧数
		this.Frame = 0;//当前帧

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        //获取鼠标位置
        Vector2 mousePosition = GetGlobalMousePosition();
		//看向某点
		LookAt(mousePosition);
		//计时
		time += delta;
		//切换纹理
		if (time > 1)
		{
			time = 0;
			//获取下一帧
			int index = this.Frame + 1;
			if (index > 3) index = 0;
			//让精灵加载新的纹理
			this.Frame = index;
		}
	}
}
