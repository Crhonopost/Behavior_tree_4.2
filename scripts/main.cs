using Godot;
using System;
using System.Linq;

public partial class main : Node
{
    Node2D scene;
    UI ui;

    public override void _Ready()
    {
        scene = GetNode<Node2D>("Scene");
        ui = GetNode<UI>("UI");
        ui.LoadScene += Launch;
    }

    public void Launch(String scenePath){
        scene.GetChildren().Select<Node, Node>((node, number) => {
            node._ExitTree();
            return null;
        });

        PackedScene childScene = ResourceLoader.Load<PackedScene>(scenePath);

        scene.AddChild(childScene.Instantiate());
    }
}
