using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProcessingNode
{
    public Action NextExcute;

    /// <summary>このノードで行う処理を書く</summary>
    /// <param name="value">前のノードで処理が行われた値</param>
    public abstract void Excecute<T>(T value);

    /// <summary>次のノードに値を渡す処理</summary>
    protected abstract void ToNextNodes<T>(T value);
}
