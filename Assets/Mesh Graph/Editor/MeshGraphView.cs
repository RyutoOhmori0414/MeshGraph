using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class MeshGraphView : GraphView
{
    public MeshGraphView(MeshGraphEditorWindow editor) : base()
    {
        styleSheets.Add(Resources.Load<StyleSheet>("GridBackGround"));
        GridBackground gridBackground = new GridBackground();
        Insert(0, gridBackground);
        gridBackground.StretchToParentSize();

        // 初期ノード
        AddElement(new InputNode());
        AddElement(new OutputNode());

        this.StretchToParentSize();
        SetupZoom(ContentZoomer.DefaultMinScale, ContentZoomer.DefaultMaxScale);
        this.AddManipulator(new ContentDragger());
        this.AddManipulator(new SelectionDragger());
        this.AddManipulator(new RectangleSelector());

        // Create Node関係
        var menuWindowProvider = ScriptableObject.CreateInstance<SearchMenuWindowProvider>();
        menuWindowProvider.Initialize(this, editor);
        nodeCreationRequest += context =>
        {
            SearchWindow.Open(new SearchWindowContext(context.screenMousePosition), menuWindowProvider);
        };
    }

    public override List<Port> GetCompatiblePorts(Port startPort, NodeAdapter nodeAdapter)
    {
        var compatiblePorts = new List<Port>();

        compatiblePorts.AddRange(ports.ToList().Where(port => 
        {
            if (startPort.node == port.node ||
                startPort.direction == port.direction ||
                startPort.portType != port.portType)
            {
                return false;
            }

            return true;
        }));

        return compatiblePorts;
    }
}
