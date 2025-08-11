using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class FabricEnemy
{
    [SerializeField] protected GameObject _prefab;

    public abstract IEnemy CreateEnemy(Vector2 position, List<GameObject> path);

    public void SetPrefab(GameObject prefab) => _prefab = prefab;
}