using UnityEditor;
using UnityEngine;

public class MeshGraphEditorWindow : EditorWindow
{
    private static ScriptableMeshGraph _currentMeshGraph;

    // メニューバーから開ける処理　一度ScriptableObjectから開けないと開かない
    [MenuItem("Window/Open Mesh Graph")]
    public static void Open()
    {
        if (_currentMeshGraph == null) return;

        OpenWindow();
    }

    // ScriptableObjectからGraphを開く処理
    public static void Open(ScriptableMeshGraph meshGraph)
    {
        // 最後に開いたScriptableObjectを記憶しておく
        _currentMeshGraph = meshGraph;

        OpenWindow();
    }

    private static void OpenWindow()
    {
        MeshGraphEditorWindow meshGraphEditorWindow = CreateInstance<MeshGraphEditorWindow>();
        meshGraphEditorWindow.Show();
        meshGraphEditorWindow.titleContent = new GUIContent("Mesh Graph Editor");
    }

    // 開いた際に呼び出される処理
    private void OnEnable()
    {
        var graphView = new MeshGraphView(this);
        rootVisualElement.Add(graphView);
        graphView.ScriptableMeshGraph = _currentMeshGraph;
    }
}
