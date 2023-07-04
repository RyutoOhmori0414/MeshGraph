using UnityEngine;
using UnityEditor.Experimental.GraphView;

public class LogNode : GraphNode
{
    private Port _inputString;

    public LogNode()
    {
        title = "Log";

        var inputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Input, Port.Capacity.Single, typeof(string));
        inputPort.portName = "In";
        inputPort.portColor = Color.yellow;
        inputContainer.Add(inputPort);

        _inputString = Port.Create<Edge>(Orientation.Horizontal, Direction.Input, Port.Capacity.Single, typeof(string));
        _inputString.portName = "In";
        _inputString.portColor = Color.yellow;
        inputContainer.Add(_inputString);

        var outputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Output, Port.Capacity.Single, typeof(string));
        outputPort.portName = "Out";
        outputPort.portColor = Color.yellow;
        outputContainer.Add(outputPort);
    }

    public override void OnSave()
    {
        throw new System.NotImplementedException();
    }
}
