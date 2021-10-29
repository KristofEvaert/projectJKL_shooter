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

    private Sprite sprite;
    public override void _Ready()
    {
        GD.Print("hello world");

        sprite = GetNode<Sprite>("Sprite");
    }
    
    public override void _PhysicsProcess(float delta)
    {
        var velocityVec = GetDirectionVec() * Speed;

        if(velocityVec != Vector2.Zero)
            sprite.Rotation = velocityVec.Angle();

        this.MoveAndSlide(velocityVec);

    }

    public static Vector2 GetDirectionVec()
    {
        var yAxisSpeed = (Input.GetActionStrength("down") - Input.GetActionStrength("up"));
        var xAxisSpeed = (Input.GetActionStrength("right") - Input.GetActionStrength("left"));

        // restricts it from going faster than one when combining two angles
        return new Vector2(xAxisSpeed, yAxisSpeed)
            .Normalized()
            .Clamped(1);
    }
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
