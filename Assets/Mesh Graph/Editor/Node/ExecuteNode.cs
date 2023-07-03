using UnityEngine;
using UnityEditor.Experimental.GraphView;

public abstract class ExecuteNode : Node
{
    public abstract void Execute();
}