using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float zSpawnPosition;

    public float maxXSpawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, 1f);
    }

    private void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3();
        spawnPosition.x = Random.Range(-maxXSpawnPosition, maxXSpawnPosition);
        spawnPosition.z = zSpawnPosition;
        spawnPosition.y = 0f;

        Instantiate(enemyPrefab, spawnPosition, Quaternion.Euler(0f, -180f, 0f));
    }
}
