using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessingInputNode : ProcessingNode, IMeshExecute, IMeshSet
{   
    private List<(ProcessingNode, Type, string)> _outputNodes = new List<(ProcessingNode, Type, string)>();
    private Mesh _mesh;

    Mesh IMeshExecute.Execute(string portName = "")
    {
        return _mesh.Copy();
    }

    public override void Set(List<(ProcessingNode, Type, string)> inputNodes = null, List<(ProcessingNode, Type, string)> outputNodes = null)
    {
        _outputNodes = outputNodes;
    }

    void IMeshSet.SetMesh(Mesh mesh)
    {
        _mesh = mesh;
    }
}
