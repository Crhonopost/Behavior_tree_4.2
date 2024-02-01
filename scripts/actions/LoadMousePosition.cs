using BehaviorTree;
using Godot;

public partial class LoadMousePosition : BTLeaf
{
    [Export]
    private string targetKey;

    [Export]
    private string mouseKey;

    public override BTState Tick(Node agent, BTBlackboard blackboard)
    {
      var mousePos = blackboard.getValue(mouseKey);

      blackboard.setValue(mousePos, targetKey);

      return BTState.SUCCESS;
    }
}
