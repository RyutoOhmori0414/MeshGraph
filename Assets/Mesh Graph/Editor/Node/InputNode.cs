using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class InputNode : Node
{
    // 入力を受け取るポート
    public InputNode()
    {
        title = "Input";

        var outputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Output, Port.Capacity.Multi, typeof(Mesh));
        outputPort.portName = "Out";
        outputPort.portColor = Color.green;
        outputContainer.Add(outputPort);
    }
}
