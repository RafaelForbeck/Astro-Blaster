using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    public List<EnemySpawner> spawners;
    private int level = 0;

    private void Start()
    {
        foreach (var spawner in spawners)
        {
            spawner.StopSpawner();
        }
        StartSpawner(level);
    }

    private void StartSpawner(int index)
    {
        spawners[index].StartSpawn();
    }

    public void WaveEnded()
    {
        level += 1;
        if (level < spawners.Count)
        {
            spawners[level].StartSpawn();
        } else
        {
            // Fim de fase, avisar o GameManager
            print("Fim de fase");
        }
    }
}
