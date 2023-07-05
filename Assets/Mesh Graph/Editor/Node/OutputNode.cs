using System;
using System.Linq;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class OutputNode : GraphNode
{
    private Port _inputPort;
    private List<(ProcessingNode, Type, string)> _inputNodeData = new List<(ProcessingNode, Type, string)>();
    

    // 出力を受け取るポート
    public OutputNode()
    {
        title = "Output";

        _inputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Input, Port.Capacity.Multi, typeof(Mesh));
        _inputPort.portName = "In";
        _inputPort.portColor = Color.green;
        inputContainer.Add(_inputPort);
    }

    public override void OnSave()
    {
        foreach (var edge in _inputPort.connections)
        {
            _inputNodeData.Add((((GraphNode)edge.output.node).ProcessingNode, edge.output.portType, edge.output.portName));
        }
        _processingNode.Set();
    }
}
