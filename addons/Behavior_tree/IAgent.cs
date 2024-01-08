using System.Collections.Generic;
using Godot;

namespace BehaviorTree;

public interface IAgent{
    public void executeAction(AgentActions action, KeyValuePair<string, Variant>[] args);
}

public enum AgentActions {
    GO_TO
}