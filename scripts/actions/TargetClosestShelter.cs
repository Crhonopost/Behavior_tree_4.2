using System;
using System.Collections.Generic;
using BehaviorTree;
using Godot;

public partial class TargetClosestShelter : BTLeaf
{
	[Export]
	private string shelterLocationKey;
	
	[Export]
	private string targetKey;

    public override BTState Tick(Node agent, BTBlackboard blackboard)
    {
		Vector2 position = ((Node2D) agent).Position;
		var shelters = GetTree().GetNodesInGroup(GroupsEnum.Shelter);

		Vector2 closestPosition = ((Node2D) shelters[0]).Position;
		float closest = (position - closestPosition).Length();
		foreach (Node2D shelter in shelters)
		{
			var closestTest = (position - closestPosition).Length();
			if(closestTest < closest){
				closest = closestTest;
				closestPosition	= shelter.Position;
			}
		}

		blackboard.setValue(closestPosition, targetKey);
		return BTState.SUCCESS;
	}

}
