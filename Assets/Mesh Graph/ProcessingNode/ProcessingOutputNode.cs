using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class ProcessingOutputNode : ProcessingNode, IMeshExecute
{
    private List<(ProcessingNode, Type, string)> _inputNodes = new List<(ProcessingNode, Type, string)>();

    public override void Set(List<(ProcessingNode, Type, string)> inputNodes = null, List<(ProcessingNode, Type, string)> outputNodes = null)
    {
        _inputNodes = inputNodes;
    }

    Mesh IMeshExecute.Execute(string portName)
    {
        CombineInstance[] comb = new CombineInstance[_inputNodes.Count];

        for (int i = 0; i < _inputNodes.Count; i++)
        {
            if (_inputNodes[i].Item1 is IMeshExecute)
            {
                comb[i].mesh = ((IMeshExecute)_inputNodes[i].Item1).Execute();
            }
        }

        Mesh mesh = new Mesh();
        mesh.CombineMeshes(comb);

        return mesh;
    }
}
