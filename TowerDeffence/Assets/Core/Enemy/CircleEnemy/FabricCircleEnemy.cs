using System.Collections.Generic;
using UnityEngine;


public class FabricCircleEnemy : FabricEnemy
{
    public override IEnemy CreateEnemy(Vector2 position, List<GameObject> path)
    {
        CircleEnemy CircleEnemy = GameObject.Instantiate(_prefab).GetComponent<CircleEnemy>();
        CircleEnemy.Damage = 2;
        CircleEnemy.Health = 30;
        CircleEnemy.Speed = 2;
        CircleEnemy.Initialize(path);
        CircleEnemy.transform.position = position;

        return CircleEnemy;
    }
}