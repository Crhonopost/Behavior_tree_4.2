using Godot;
using System;

namespace BehaviorTree;

[GlobalClass, Icon("res://addons/Behavior_tree/Icons/BT.png")]
public partial class BT: BehaviourTree
// manque un truc pour réinitialiser l'etat de l'arbre sans que ca rame 
{
    /*
    que dois faire le behavior tree?
    - il doit être capable d'initialiser le tick qui permettra de contacter toutes les branches
    - reinitialiser les noeuds quand tout l'arbre a été parcouru?
    - il optimisera les appels aux noeuds quand y'en aura trop ? (idée d'opti: faire tout en 2 frames, une pour tick et une pour process)
    - envoyer le blackboard?
    - faut un agent, une entité à laquelle il est lié
    */

    private Node agent;
    [Export]
    private NodePath agentPath;

    private BTBlackboard blackboard;

    private BTNode root;

    private bool isActive;

    public void setAgentPath(NodePath path){
        agentPath = path;
    }

    public override void _Ready()
    {
        agent = GetNode(agentPath);
        isActive = true;
        blackboard = new BTBlackboard();
        root = GetChild<BTNode>(0);
    }

    public override void _PhysicsProcess(double delta)
    {
        if(isActive){
            root.PreTick(agent, blackboard);
            root.Tick(agent, blackboard);
            root.PostTick(agent, blackboard);
        }
    }
}