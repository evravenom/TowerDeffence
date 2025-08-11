using UnityEngine;
using System.Collections.Generic;
using System;

public abstract class NodeAbstract : MonoBehaviour
{
    [SerializeField] protected List<NodeAbstract> nextNodes;

    public abstract void Apply();
}