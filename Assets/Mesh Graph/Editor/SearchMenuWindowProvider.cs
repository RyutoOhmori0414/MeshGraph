using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class SearchMenuWindowProvider : ScriptableObject, ISearchWindowProvider
{
    private MeshGraphView _graphView;
    private MeshGraphEditorWindow _editorWindow;

    public void Initialize(MeshGraphView graphView, MeshGraphEditorWindow editorWindow)
    {
        _graphView = graphView;
        _editorWindow = editorWindow;
    }

    public List<SearchTreeEntry> CreateSearchTree(SearchWindowContext context)
    {
        var entries = new List<SearchTreeEntry>();
        entries.Add(new SearchTreeGroupEntry(new GUIContent("Create Node")));

        // Create Nodeの下にBaseというグループを作った
        entries.Add(new SearchTreeGroupEntry(new GUIContent("Base")) { level = 1 });

        entries.Add(new SearchTreeEntry(new GUIContent(nameof(MyNode))) { level = 2 , userData = typeof(MyNode) });
        entries.Add(new SearchTreeEntry(new GUIContent(nameof(InputNode))) { level = 2 , userData = typeof(InputNode) });
        entries.Add(new SearchTreeEntry(new GUIContent(nameof(OutputNode))) { level = 2 , userData = typeof(OutputNode) });
        entries.Add(new SearchTreeEntry(new GUIContent(nameof(StringNode))) { level = 2 , userData = typeof(StringNode) });
        entries.Add(new SearchTreeEntry(new GUIContent(nameof(LogNode))) { level = 2, userData = typeof(LogNode)});

        return entries;
    }

    public bool OnSelectEntry(SearchTreeEntry SearchTreeEntry, SearchWindowContext context)
    {
        var type = SearchTreeEntry.userData as Type;
        var node = Activator.CreateInstance(type) as Node;

        var worldMousePos = _editorWindow.rootVisualElement.ChangeCoordinatesTo(_editorWindow.rootVisualElement.parent, context.screenMousePosition - _editorWindow.position.position);
        var localMousePos = _graphView.contentViewContainer.WorldToLocal(worldMousePos);
        node.SetPosition(new Rect(localMousePos, new Vector2(100, 100)));

        _graphView.AddElement(node);
        return true;
    }
}
