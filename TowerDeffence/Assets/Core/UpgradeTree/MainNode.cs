using UnityEngine;

public class MainNode : NodeAbstract
{
    public override void Apply()
    {
        foreach (EnemySpawner enemySpawner in FindObjectsByType<EnemySpawner>(FindObjectsSortMode.None))
        {
            foreach (Wave wave in enemySpawner.Waves)
            {

            }
        }
    }
}


public class DecoratedFabric
{
    
}