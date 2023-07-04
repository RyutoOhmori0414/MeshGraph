using UnityEngine;
using UnityEditor.Experimental.GraphView;

public abstract class GraphNode : Node
{
    protected ProcessingNode _processingNode;

    public ProcessingNode ProcessingNode => _processingNode;

    public abstract void OnSave();
}