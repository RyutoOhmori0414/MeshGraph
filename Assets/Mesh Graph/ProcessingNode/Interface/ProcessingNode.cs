using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class ProcessingNode
{
    /// <summary>
    /// このノードのデータを更新する関数
    /// </summary>
    /// <param name="inputNodes"></param>
    /// <param name="outputNodes"></param>
    public abstract void Set(List<(ProcessingNode, Type, string)> inputNodes = null, List<(ProcessingNode, Type, string)> outputNodes = null);
}
