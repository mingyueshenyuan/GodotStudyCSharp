using Godot;
using System;

public partial class GameManager : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		scoreLabel = GetNode<Label>("CanvasLayer/Label");
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	Label scoreLabel;
	[Export]
	public int Number = 5;
	[Export]
	public AnimationPlayer _animationPlayer;

	int Score = 0;
	public void AddCoin()
	{
		Score += 1;
	
		if (scoreLabel!=null)
		{
			scoreLabel.Text= "已经收集到金币："+Score.ToString();
		}
		if (Score==7)
		{
			_animationPlayer.Play("move");
		}

		if (Score==14)
		{
			if (scoreLabel!=null)
			{
				scoreLabel.Text= "恭喜，你已收集全部金币："+Score.ToString();
			}
		}
	}
}
