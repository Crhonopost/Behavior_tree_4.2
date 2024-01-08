using Godot;

namespace BehaviorTree.Decorator;

[GlobalClass]
public partial class BTDecorator : BTNode
{
    protected BTNode child;

    public override void _Ready()
    {
        child = GetChild<BTNode>(0);
    }
}