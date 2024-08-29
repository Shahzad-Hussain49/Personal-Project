using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] GameObject[] enemyPrefabs;
    [SerializeField] GameObject powerUpPrefab;

    private float spawnPositionZ = 7.0f;
    private float spawnPositionY = 0.75f;
    private float spawnRangeX = 12.0f;
    private float powerUpSpawnPositionZ = 5.0f;
    [Header("Invoke Repeating Variables")]
    private float startDelay = 1.0f;
    private float repeatRate = 1.5f;
    private float powerUpSpawnTime = 5.0f;


    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, repeatRate);
        InvokeRepeating("SpawnPowerUp", startDelay, powerUpSpawnTime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(randomX, spawnPositionY, spawnPositionZ);
        int randomIndex = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[randomIndex], spawnPosition, enemyPrefabs[randomIndex].transform.rotation);
    }

    void SpawnPowerUp()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(randomX, spawnPositionY, powerUpSpawnPositionZ);
        Instantiate(powerUpPrefab,spawnPosition, powerUpPrefab.transform.rotation);
    }
}
