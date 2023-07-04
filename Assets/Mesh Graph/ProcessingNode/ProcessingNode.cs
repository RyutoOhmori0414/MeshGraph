using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProcessingNode
{
    /// <summary>このノードで行う処理を書く</summary>
    /// <param name="value">前のノードで処理が行われた値</param>
    public abstract void Excecute<T>();

    /// <summary>次のノードに値を渡す処理</summary>
    protected abstract void ToNextNodes<T>(T value);

    public abstract void Set(List<ProcessingNode> inputNodes = null, List<ProcessingNode> outputNodes = null);
}
