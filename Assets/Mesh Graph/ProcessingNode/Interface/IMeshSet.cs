using UnityEngine;

public interface IMeshSet
{
    /// <summary>
    /// 外部からMeshをセットされる際によばれる
    /// </summary>
    public void SetMesh(Mesh mesh);
}
