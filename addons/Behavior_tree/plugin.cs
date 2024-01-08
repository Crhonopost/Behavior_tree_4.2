#if TOOLS
using Godot;

[Tool]
public partial class plugin : EditorPlugin
{
	private string baseUri = "addons/Behavior_tree";
	public override void _EnterTree()
	{
		// var baseScript = GD.Load<Script>($"{baseUri}/BasicNode/BehaviourTree.cs");
		// var btScript = GD.Load<Script>($"{baseUri}/BasicNode/BT.cs");
		// var btNodeScript = GD.Load<Script>($"{baseUri}/BasicNode/BTNode.cs");
		
		// var baseIcon = GD.Load<Texture2D>("icon.svg");
		
		// AddCustomType("BehaviourTree", "Node", baseScript, baseIcon);
		// AddCustomType("BT", "BehaviourTree", btScript, baseIcon);
		// AddCustomType("BTNode", "BehaviourTree", btNodeScript, baseIcon);
	}

	public override void _ExitTree()
	{
		// Clean-up of the plugin goes here.
	}
}
#endif
