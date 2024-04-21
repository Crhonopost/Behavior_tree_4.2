using Godot;
using System;

public partial class UI : Control
{
	[Signal]
	public delegate void LoadSceneEventHandler(String scenePath);
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GetNode<Button>("VBoxContainer/Demo1").Pressed += () => EmitSignal("LoadScene", "res://scenes/Demo1.tscn");
	}
}
