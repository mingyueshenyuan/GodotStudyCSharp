using Godot;
using System;

public partial class silme : Node2D
{
	public float moveSpeed = 60;
	private int direction = 1;
	RayCast2D _rayCast2DL, _rayCast2DR;
	AnimatedSprite2D  _animatedSprite2D;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_rayCast2DL=GetNode<RayCast2D>("RayCast2DL");
		_rayCast2DR=GetNode<RayCast2D>("RayCast2DR");
		_animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	public override void _Process(double delta)
	{
		base._Process(delta);
		

		if (_rayCast2DL.IsColliding())
		{
			direction = 1;
		}else if(_rayCast2DR.IsColliding())
		{
			direction = -1;
		}
		
		_animatedSprite2D.FlipH=direction<0;
		
		var newPosition = Position;
		newPosition.X += (float)delta*moveSpeed*direction;
		Position = newPosition;
	}
}
