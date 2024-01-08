using Godot;

namespace BehaviorTree.Decorator;

[GlobalClass, Icon("res://addons/Behavior_tree/Icons/BTDecorator.png")]
public partial class BTDecorator : BTNode
{
    protected BTNode child;

    public override void _Ready()
    {
        child = GetChild<BTNode>(0);
    }
}