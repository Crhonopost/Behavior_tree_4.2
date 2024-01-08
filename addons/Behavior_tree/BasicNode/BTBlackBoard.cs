using Godot;

namespace BehaviorTree;

public partial class BTBlackboard
{
    [Export]
    private Godot.Collections.Dictionary data;

    public void setValue(Variant value, string key){
        data[key] = value;
    }

    public object getValue(string key){
        return data[key];
    }

    public bool contains(string key){
        return data.ContainsKey(key);
    }
}