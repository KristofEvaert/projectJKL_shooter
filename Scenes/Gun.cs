using Godot;
using System;

public class Gun : Node2D
{
    private Position2D pivot;
    private float rotation;

    // angle 
    float distance;
    public override void _Ready()
    {
        pivot = GetNode<Position2D>("../Pivot");
        distance = this.Position.x;
    }

    public override void _Process(float delta)
    {
        base._Process(delta);

        var mousePos = this.GetViewport().GetMousePosition();
        var relativePlayerPos = pivot.GetGlobalTransformWithCanvas();
        var vec = relativePlayerPos.origin;

        rotation = mousePos.AngleToPoint(vec);

        var position = new Vector2(distance, 0).Rotated(rotation);
        this.Rotation = rotation;
        Position = position;

        if (Input.IsActionJustPressed("shoot"))
        {
            this.Shoot();
        }

    }

    private void Shoot()
    {
        var speed = 100;

        var velocityVec = new Vector2(100, 0).Rotated(Rotation);

    }


}
