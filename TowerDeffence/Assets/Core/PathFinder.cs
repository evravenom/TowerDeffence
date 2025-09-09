using System;
using System.Collections.Generic;
using SerializeReferenceEditor;
using UnityEngine;

[System.Serializable]
public class PathFinder
{
    [field: SerializeField] public List<GameObject> DefaultPath { get; private set; }
    [field: SerializeField] public List<Path> EnemyToPath { get; private set; }


    [System.Serializable]
    public class Path
    {
        [field: SerializeField] public List<GameObject> path { get; private set; }
        [SerializeReference, SR] private FabricEnemy enemyFabric;

        public EnemyType enemyType;
    }


    public List<GameObject> GetPath(EnemyType enemyType)
    {
        if (EnemyToPath.Count != 0)
        {
            foreach (Path path in EnemyToPath)
            {
                if (path.enemyType == enemyType)
                {
                    return path.path;
                }
            }
        }

        return DefaultPath;
    }
}