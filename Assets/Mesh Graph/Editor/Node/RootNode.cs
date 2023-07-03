using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RootNode : Node
{
    public RootNode() : base()
    {
        title = "Root";

        capabilities -= Capabilities.Deletable;
        var outputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Output, Port.Capacity.Single, typeof(Port));
        outputPort.portName = "Out";
        outputContainer.Add(outputPort);
    }
}
