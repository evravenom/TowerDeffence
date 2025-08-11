using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using SerializeReferenceEditor;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private PathFinder _pathFinder;

    public List<Wave> Waves;

    [SerializeField, Min(1)] private int _waveCount = 1;


    private void Awake()
    {
        StartCoroutine(SpawnWave());
    }


    public IEnumerator SpawnWave()
    {
        Wave wave = Waves[_waveCount - 1];

        while (!IsWaveEnded(wave))
        {
            int enemyID = Random.Range(0, wave.SpawnEnemies.Count);
            wave.SpawnEnemies[enemyID].Fabric.CreateEnemy(transform.position, _pathFinder.GetPath(wave.SpawnEnemies[enemyID].Fabric.GetType()));
            wave.SpawnEnemies[enemyID].Count -= 1;

            if (wave.SpawnEnemies[enemyID].Count == 0)
                wave.SpawnEnemies.RemoveAt(enemyID);

            yield return new WaitForSeconds(wave.Delay);
        }

        _waveCount++;
    }


    private bool IsWaveEnded(Wave wave) => wave.SpawnEnemies.Count == 0;



}


[System.Serializable]
public class Wave
{
    [field: SerializeField] public List<WaveEnemyData> SpawnEnemies { get; private set; }
    [field: SerializeField] public float Delay { get; private set; } 
}


[System.Serializable]
public class WaveEnemyData
{
    [field: SerializeReference, SR] public FabricEnemy Fabric { get; private set; }
    public int Count;
}