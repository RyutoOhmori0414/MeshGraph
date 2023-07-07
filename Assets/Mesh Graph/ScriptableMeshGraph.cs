using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MeshGraph", menuName = "MeshGraph", order = 0)]
public class ScriptableMeshGraph : ScriptableObject
{
    private List<ProcessingNode> _processedNodes = new List<ProcessingNode>();
    private ProcessingInputNode _inputNode;
    private ProcessingOutputNode _outputNode;

    public void InitNode(ProcessingInputNode input, ProcessingOutputNode output)
    {
        _inputNode = input;
        _outputNode = output;
    }

    public void SetNode(List<ProcessingNode> nodes)
    {
        _processedNodes = nodes;
    }
}
