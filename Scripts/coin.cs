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
        gm= GetNode<GameManager>("%GameManager");
    }

    GameManager  gm;
    private void CoinEntered(PhysicsBody2D body)
    {
        GD.Print("金币+1");
        gm.AddCoin();
        Animation.Play("PickUp");
        
    }
}
