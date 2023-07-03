using UnityEngine;
using UnityEditor.Experimental.GraphView;

public class MyNode : Node
{
    public MyNode()
    {
        title = "Sample";
        var inputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Input, Port.Capacity.Single, typeof(Mesh));
        inputPort.portName = "In";
        inputPort.portColor = Color.green;
        inputContainer.Add(inputPort);

        var outputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Output, Port.Capacity.Single, typeof(Mesh));
        outputPort.portName = "Out";
        outputPort.portColor = Color.green;
        outputContainer.Add(outputPort);
    }
}
