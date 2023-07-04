using System.Linq;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class OutputNode : GraphNode
{
    private Port _inputPort;

    // 出力を受け取るポート
    public OutputNode()
    {
        _processingNode = new ProcessingOutputNode();
        title = "Output";

        _inputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Input, Port.Capacity.Multi, typeof(Mesh));
        _inputPort.portName = "In";
        _inputPort.portColor = Color.green;
        inputContainer.Add(_inputPort);
    }

    public override void OnSave()
    {
        _processingNode.Set(_inputPort.connections.Select(x => ((GraphNode)x.output.node).ProcessingNode).ToList());
    }
}
