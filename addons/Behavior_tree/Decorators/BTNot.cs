using Godot;

namespace BehaviorTree.Decorator;

[GlobalClass, Icon("res://addons/Behavior_tree/Icons/BTRepeater.png")]
public partial class BTNot: BTDecorator {
    public override BTState Tick(Node agent, BTBlackboard blackboard)
    {
        switch(child.Tick(agent, blackboard)){
            case BTState.RUNNING:
                return BTState.RUNNING;
            case BTState.FAILURE: 
                return BTState.SUCCESS;
            case BTState.SUCCESS:
                return BTState.FAILURE;
        }
        return BTState.FAILURE;
    }
}