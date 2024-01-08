using Godot;

namespace BehaviorTree;

public partial class BTBlackboard
{
    private Godot.Collections.Dictionary<string, Variant> data;

    public BTBlackboard(){
        data = new Godot.Collections.Dictionary<string, Variant>();
    }

    public void setValue(Variant value, string key){
        data[key] = value;
    }

    public Variant getValue(string key){
        return data[key];
    }

    public bool contains(string key){
        return data.ContainsKey(key);
    }
}