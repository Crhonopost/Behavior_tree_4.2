#if TOOLS
using System.Reflection.Metadata;
using Godot;

namespace BehaviorTree;


[Tool]
public partial class plugin : EditorPlugin
{
	public override void _EnterTree()
	{
	}

	public override void _ExitTree()
	{
		// Clean-up of the plugin goes here.
	}
}
#endif
