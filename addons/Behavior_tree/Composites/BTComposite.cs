using Godot;

namespace BehaviorTree;

[GlobalClass]
public partial class BTComposite : BTNode
{
    private Godot.Collections.Array<BTNode> childs;
    private BTNode _currentChild;
    public BTNode CurrentChild{get;set;}

    public virtual void reset(){
        CurrentChild = getChilds()[0];
    }

    public bool HasNext(){
        return getChilds().IndexOf(CurrentChild) < getChilds().Count - 1;
    }

    public BTNode Next(){
        return getChilds()[getChilds().IndexOf(CurrentChild) + 1];
    }

    public override void _Ready()
    {
        childs = new Godot.Collections.Array<BTNode>();
        foreach(BTNode c in GetChildren()){
            childs.Add(c);
        }
    }

    public Godot.Collections.Array<BTNode> getChilds(){
        return childs;
    }

    public void setChilds(Godot.Collections.Array<BTNode> cs){
        childs = cs;
    }
}