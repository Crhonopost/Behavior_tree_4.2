using Godot;

namespace BehaviorTree;

[GlobalClass, Icon("res://addons/Behavior_tree/Icons/BTSequence.png")]
public partial class BTSequence : BTComposite{

    public override void _Ready()
    {
        base._Ready();
        reset();
    }

    public override BTState Tick(Node agent, BTBlackboard blackboard)
    {
        BTState etat = CurrentChild.Tick(agent, blackboard);
        if(etat == BTState.SUCCESS){
            if(HasNext()){
                Next();
                return BTState.RUNNING;
            } else {
                reset();
                return BTState.SUCCESS;
            }
        }
        else if(etat == BTState.FAILURE){
            reset();
            return BTState.FAILURE;
        }
        else
        {
            return BTState.RUNNING;
        }
    }
}
