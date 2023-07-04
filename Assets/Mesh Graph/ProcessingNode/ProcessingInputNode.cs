using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessingInputNode : ProcessingNode
{   
    private List<ProcessingNode> _outputNodes = new List<ProcessingNode>();

    public override void Excecute<T>(T value)
    {
        ToNextNodes(value);
    }

    public override void Set(List<ProcessingNode> inputNodes, List<ProcessingNode> outputNodes)
    {
        _outputNodes = outputNodes;
    }

    protected override void ToNextNodes<T>(T value)
    {
        foreach (var node in _outputNodes)
        {
            node.Excecute(value);
        }
    }

}
