using UnityEngine;

public static class MeshExtension
{
    public static Mesh Copy(this Mesh source)
    {
        Mesh copy = new Mesh();

        copy.vertices = source.vertices;
        copy.uv = source.uv;
        copy.uv2 = source.uv2;
        copy.uv3 = source.uv3;
        copy.uv4 = source.uv4;
        copy.uv5 = source.uv5;
        copy.uv6 = source.uv6;
        copy.uv7 = source.uv7;
        copy.uv8 = source.uv8;
        copy.triangles = source.triangles;

        copy.bindposes = source.bindposes;
        copy.boneWeights = source.boneWeights;
        copy.bounds = source.bounds;
        copy.colors = source.colors;
        copy.colors32 = source.colors32;
        copy.normals = source.normals;
        copy.subMeshCount = source.subMeshCount;
        copy.tangents = source.tangents;

        return copy;
    }
}
