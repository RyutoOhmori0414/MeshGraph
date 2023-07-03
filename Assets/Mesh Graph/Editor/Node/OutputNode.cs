using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class OutputNode : Node
{
    // 出力を受け取るポート
    public OutputNode()
    {
        title = "Output";

        var inputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Input, Port.Capacity.Multi, typeof(Mesh));
        inputPort.portName = "In";
        inputPort.portColor = Color.green;
        inputContainer.Add(inputPort);
    }
}
