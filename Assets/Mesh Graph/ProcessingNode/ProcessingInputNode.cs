using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessingInputNode : ProcessingNode, IMeshExecute
{   
    private List<(ProcessingNode, Type, string)> _outputNodes = new List<(ProcessingNode, Type, string)>();
    private Mesh _mesh;

    public Mesh Execute(string portName = "")
    {
        return _mesh.Copy();
    }

    public override void Set(List<(ProcessingNode, Type, string)> inputNodes = null, List<(ProcessingNode, Type, string)> outputNodes = null)
    {
        throw new NotImplementedException();
    }
}
