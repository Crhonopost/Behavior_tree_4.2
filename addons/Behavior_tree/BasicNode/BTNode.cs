using Godot;
using System;


/*
liste des nodes à implémenter:
 - composite:
   * sequence (enchaine les success, si failure: ?)
   * selector/fallback (s'arrete au premier success, si failure : passe au suivant)
   * leur variante random
   * node qui en execute pusieur en parallele maybe?
 - decorator:
   * inverter (inverse le resultat de son enfant, si running : ?)
   * repeater (infinit, certain nb de fois)
   * repeatUntilFail (c'est dit dans le nom ...)
   * j'avais vu un wait, jsp si ca peut etre utile

se renseigner sur les stacks
*/

namespace BehaviorTree;

[GlobalClass, Icon("res://addons/Behavior_tree/Icons/BTNode.png")]
public abstract partial class BTNode: BehaviourTree
{
    public virtual void PreTick(Node agent, BTBlackboard blackboard){} // appellée avant Tick() 
    public virtual BTState Tick(Node agent, BTBlackboard blackboard){ // manque le blackboard
        return BTState.FAILURE;
    }

    public virtual void PostTick(Node agent, BTBlackboard blackboard){}// appellée apres Tick()
}
