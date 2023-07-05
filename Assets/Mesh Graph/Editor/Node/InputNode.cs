using System.Linq;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class InputNode : GraphNode
{
    private Port _outputPort;

    // 入力を受け取るポート
    public InputNode()
    {
        _processingNode = new ProcessingInputNode();

        title = "Input";

        _outputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Output, Port.Capacity.Multi, typeof(Mesh));
        _outputPort.portName = "Out";
        _outputPort.portColor = Color.green;
        outputContainer.Add(_outputPort);
    }

    public override void OnSave()
    {
        _processingNode.Set();
    }
}
