using Godot;

public partial class Agent : CharacterBody2D
{
	private Vector2 _target;
	public Vector2 Target{
		get {
			return _target;
		}
		set {
			_target = value;
			navAgent.TargetPosition = _target;
		}
	}
	public float speed = 100;

	[Export]
	private NavigationAgent2D navAgent;

    public override void _PhysicsProcess(double delta)
    {
		if(navAgent.IsNavigationFinished()) return;

		Vector2 currentPos = GlobalTransform.Origin;
		Vector2 nextPathPosition = navAgent.GetNextPathPosition();

		Velocity = currentPos.DirectionTo(nextPathPosition) * speed;
		MoveAndSlide();
    }
}