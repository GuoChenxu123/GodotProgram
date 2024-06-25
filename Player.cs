using Godot;
using System;

public partial class Player : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		if (Input.IsActionJustPressed("右"))
		{
			//销毁所有敌人节点_这里引入组的概念
			var enemys = this.GetTree().GetNodesInGroup("小兵");
			//便利敌人节点，销毁
			foreach (var enemy in enemys)
			{
				enemy.QueueFree();
			}

		}
        if (Input.IsActionJustPressed("左"))
		{
			//动态加入分组
			//获取节点
			SceneTree sceneTree = this.GetTree();
			//var bossNode = GetNode("../boss");
			Sprite2D bossNode = (Sprite2D)sceneTree.CurrentScene.GetNode("boss");
            //加入分组
            bossNode.AddToGroup("小兵");
            //给一个分组中的节点发消息
            this.GetTree().CallGroup("小兵","test");
        }

    }
}
