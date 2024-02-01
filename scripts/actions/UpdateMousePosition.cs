using BehaviorTree;
using Godot;

public partial class UpdateMousePosition : BTLeaf
{
    [Export]
    private string mouseKey;

    public override BTState Tick(Node agent, BTBlackboard blackboard)
    {
      var mousePos = GetViewport().GetMousePosition();

      blackboard.setValue(mousePos, mouseKey);

      return BTState.SUCCESS;
    }
}
