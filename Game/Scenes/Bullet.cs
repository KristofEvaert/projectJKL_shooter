using Godot;
using System;

public class Bullet : KinematicBody2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    [Export]
    public Vector2 Velocity = new Vector2(100, 100);

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print("i exist!");
        
    }
    public override void _PhysicsProcess(float delta)
    {
        //this.MoveAndSlide(Velocity);
        var collision = this.MoveAndCollide(Velocity);
        if (collision is not null)
        {
            GD.Print(collision);
        }
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
