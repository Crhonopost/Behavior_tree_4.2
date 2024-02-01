using Godot;

public partial class Agent : CharacterBody2D
{
	public Vector2 target;
	public float speed = 100;

    public override void _PhysicsProcess(double delta)
    {
		Velocity = (target - Position).Normalized() * speed;
		MoveAndSlide();
    }
}