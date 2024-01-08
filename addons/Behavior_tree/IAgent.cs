using Godot;

namespace BehaviorTree;

public interface IAgent{
    public void execute(string command, Variant[] args);
}