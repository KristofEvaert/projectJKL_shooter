using Godot;
using System;

public class MainScene : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	public void _on_Player_PlayerShotSignal(Bullet bullet)
	{
		GD.Print(bullet);
		GD.Print("shooting");
		AddChild(bullet);
		GD.Print(bullet.Position, bullet.Velocity);
		bullet.Show();
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
