using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

public class ScriptableMeshGraphHandler
{
    // MeshGraphをOpenした際にNodeGraphを開くようにする処理
    [OnOpenAsset(0)]
    public static bool OpenMeshGraph(int instanceID, int line)
    {
        var scriptableMeshGraph = EditorUtility.InstanceIDToObject(instanceID);

        //is演算子で型キャストできるかどうか確認している
        if (scriptableMeshGraph is not ScriptableMeshGraph) return false;

        MeshGraphEditorWindow.Open((ScriptableMeshGraph)scriptableMeshGraph);
        return true;
    }
}