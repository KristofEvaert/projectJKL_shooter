using Godot;
using System;

public class Player : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.

    [Export]
    public float Speed = 100f;
    private float rotation;
    public override void _Ready()
    {
        GD.Print("hello world");
    }
    
    public override void _PhysicsProcess(float delta)
    {
        var yAxisSpeed = (Input.GetActionStrength("down") - Input.GetActionStrength("up"));
        var xAxisSpeed = (Input.GetActionStrength("right") - Input.GetActionStrength("left"));

        var velocityVec = new Vector2(xAxisSpeed, yAxisSpeed).Normalized() * Speed;

        this.MoveAndSlide(velocityVec);

    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
