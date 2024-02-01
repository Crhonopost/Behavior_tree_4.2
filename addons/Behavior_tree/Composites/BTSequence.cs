using Godot;

namespace BehaviorTree;

[GlobalClass, Icon("res://addons/Behavior_tree/Icons/BTSequence.png")]
public partial class BTSequence : BTComposite{

    public override void _Ready()
    {
        base._Ready();
        reset();
    }

    public override void PreTick(Node agent, BTBlackboard blackboard)
    {
        CurrentChild.PreTick(agent, blackboard);
    }


    public override void PostTick(Node agent, BTBlackboard blackboard)
    {
        CurrentChild.PostTick(agent, blackboard);
    }

    public override BTState Tick(Node agent, BTBlackboard blackboard)
    {
        BTState etat = CurrentChild.Tick(agent, blackboard);

        if(etat == BTState.FAILURE){
            reset();
            return BTState.FAILURE;
        }
        else if(etat == BTState.RUNNING){
            return BTState.RUNNING;
        }
        else{
            if(HasNext()){
                CurrentChild = Next();
                return BTState.RUNNING;
            } else{
                reset();
                return BTState.SUCCESS;
            }
        }
    }
}
