using System;
using Godot;

namespace BehaviorTree;

[GlobalClass, Icon("res://addons/Behavior_tree/Icons/BTComposite.png")]
public partial class BTComposite : BTNode
{
    private Godot.Collections.Array<BTNode> childs;

    private int currentChildIndex = 0;
    public BTNode CurrentChild{
        get {
            try {
                return childs[currentChildIndex];
            } catch(IndexOutOfRangeException e){
                throw e;
            }
        }
    }

    public virtual void reset(){
        currentChildIndex = 0;
    }

    public bool HasNext(){
        return currentChildIndex + 1 < childs.Count;
    }

    public BTNode Next(){
        try {
            var result = childs[currentChildIndex];
            currentChildIndex += 1;
            return result;
        } catch(IndexOutOfRangeException e){
            throw e;
        }
    }

    public override void _Ready()
    {
        childs = new Godot.Collections.Array<BTNode>();
        foreach(BTNode c in GetChildren()){
            childs.Add(c);
        }
    }
}