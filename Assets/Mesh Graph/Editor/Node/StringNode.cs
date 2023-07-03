using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.Experimental.GraphView;

public class StringNode : Node
{
    private TextField _textField;
    public string Text
    {
        get => _textField.value;
    }

    public StringNode() : base()
    {
        title = "String";

        var outputPort = Port.Create<Edge>(Orientation.Horizontal, Direction.Output, Port.Capacity.Multi, typeof(string));
        outputPort.portName = "Out";
        outputPort.portColor = Color.yellow;
        outputContainer.Add(outputPort);

        _textField = new TextField();
        mainContainer.Add(_textField);
    }
}
