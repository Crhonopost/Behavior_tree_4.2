using Godot;

namespace BehaviorTree.Decorator;

[GlobalClass, Icon("res://addons/Behavior_tree/Icons/BTRepeater.png")]
public partial class BTRepeater: BTDecorator {
    public override BTState Tick(IAgent agent, BTBlackboard blackboard)
    {
        child.Tick(agent, blackboard);
        return BTState.RUNNING;
    }
}