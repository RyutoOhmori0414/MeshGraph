using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessingOutputNode : ProcessingNode
{
    private List<ProcessingNode> _inputNodes = new List<ProcessingNode>();

    public override void Set(List<(ProcessingNode, Type, string)> inputNodes = null, List<(ProcessingNode, Type, string)> outputNodes = null)
    {
        throw new NotImplementedException();
    }
}
