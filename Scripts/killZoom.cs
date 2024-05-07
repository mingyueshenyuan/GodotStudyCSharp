using Godot;
using System;

public partial class killZoom : Area2D
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _timer = GetNode<Timer>("Timer");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }

    private Timer _timer;

    public void EnterKillZoom(PhysicsBody2D body)
    {
        GD.Print("死亡");
        Engine.TimeScale = 0.05;
        _timer.WaitTime *= Engine.TimeScale;
        _timer.Start();
    }


    public void OnTimeOut()
    {
        Engine.TimeScale = 1;
        GetTree().ReloadCurrentScene();
    }
}