using System;
using UnityEngine;

public interface IMeshExecute
{
    /// <summary>メッシュをOutputするポートに実装する</summary>
    /// <param name="portName">複数同じ型を出力する際にポートの名前によって出力を変える</param>
    /// <returns></returns>
    public Mesh Execute(string portName = "");
}
