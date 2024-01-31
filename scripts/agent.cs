using System;
using System.Collections.Generic;
using BehaviorTree;
using Godot;

public partial class Agent : CharacterBody2D, IAgent
{
	private Vector2 target;
	private int speed = 400;

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Vector2 translation = (target - Position).Normalized();
		Position += translation * (float) delta * speed;
	}

    public void executeAction(AgentActions action, KeyValuePair<string, Variant>[] args)
    {
		switch(action){
			case AgentActions.GO_TO:
				foreach(KeyValuePair<string, Variant> arg in args){
					if(arg.Key == "target"){
						target = (Vector2) arg.Value;
					}
				}
				break;
			default:
				GD.Print($"Pas d'instruction pour {action}");
				break;
		}
    }

}
