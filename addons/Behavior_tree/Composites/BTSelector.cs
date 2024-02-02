using Godot;

namespace BehaviorTree;

[GlobalClass, Icon("res://addons/Behavior_tree/Icons/BTSelector.png")]
public partial class BTSelector : BTComposite
{
    public override void _Ready()
    {
        base._Ready();
        reset();
    }

    public override BTState Tick(Node agent, BTBlackboard blackboard)
    {
        BTState etat = CurrentChild.Tick(agent, blackboard);
        if(etat == BTState.SUCCESS){
            reset();
            return BTState.SUCCESS;
        }
        else if(etat == BTState.FAILURE){
            if(HasNext()){
                Next();
                return BTState.RUNNING;
            }else {
                reset();
                return BTState.FAILURE;
            }
        }
        else
        {
            return BTState.RUNNING;
        }
    }
}
