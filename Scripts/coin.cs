using Godot;
using System;
using System.Text.Json.Serialization.Metadata;
using System.Xml.Schema;

public partial class coin : Area2D
{
    public AnimationPlayer Animation;
    public override void _Ready()
    {
        base._Ready();
        Animation= GetNode<AnimationPlayer>("AnimationPlayer");
    }

    private void CoinEntered(PhysicsBody2D body)
    {
        GD.Print("金币+1");
        Animation.Play("PickUp");
        
    }
}
