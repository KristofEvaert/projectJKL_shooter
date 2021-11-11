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

    private Position2D pivot;
    private float gunDistance;


    private DateTime lastTimeShot = DateTime.MinValue;

    [Export]
    public float Cooldown = 200f;

    Gun gun;

    [Export]
    public PackedScene BulletScene;

    private Sprite sprite;
    public override void _Ready()
    {
        GD.Print("hello world");

        sprite = GetNode<Sprite>("Sprite");
        pivot = GetNode<Position2D>("Pivot");

        gun = GetNode<Gun>("Gun");

        gunDistance =  gun.Position.Length();

    }
    
    public override void _PhysicsProcess(float delta)
    {
        var velocityVec = GetDirectionVec() * Speed;
        this.MoveGun();

        if(velocityVec != Vector2.Zero)
            sprite.Rotation = velocityVec.Angle();
        
        if(Input.IsActionPressed("shoot"))
        {
            this.Shoot();
        }


        this.MoveAndSlide(velocityVec);

    }

    [Signal]
    public delegate void PlayerShotSignal(Bullet bullet);


    public void Shoot()
    {
        var now = DateTime.Now;
        var timeSinceLastShot = now - lastTimeShot;

        if(timeSinceLastShot.TotalMilliseconds < Cooldown)
        {
            GD.Print("wait!");
            return;
        }
        lastTimeShot = now;
        GD.Print("pew!");

        var velocityVec = new Vector2(5, 0).Rotated(gun.Rotation);

        //var bullet = new Bullet(gun.GlobalPosition, velocityVec);

        var bullet = BulletScene.Instance<Bullet>();
        bullet.Position = gun.GlobalPosition;
        bullet.Velocity = velocityVec;

        EmitSignal(nameof(PlayerShotSignal), bullet);

    }

    private void MoveGun()
    {
        var mousePos = this.GetViewport().GetMousePosition();
        var relativePlayerPos = pivot.GetGlobalTransformWithCanvas();
        var vec = relativePlayerPos.origin;

        gun.Rotation = mousePos.AngleToPoint(vec);

        var position = new Vector2(gunDistance, 0).Rotated(gun.Rotation);

        gun.Position = position;
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
