using UnityEngine;
using System.Collections.Generic;
using System;

public abstract class UpgradeTreeNode : MonoBehaviour
{
    [SerializeField] protected List<UpgradeTreeNode> nextNodes;

    public void Upgrade();
    public abstract void ApplyOnScene();
}