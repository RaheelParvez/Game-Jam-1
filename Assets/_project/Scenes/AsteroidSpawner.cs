using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public int gridWidth = 5; // Number of asteroids in each row
    public int gridHeight = 5; // Number of asteroids in each column
    public float spawnInterval = 3.0f; // Time between asteroid spawns
    public float spawnRadius = 10.0f; // Maximum distance from the spawner

    private float nextSpawnTime = 0.0f;

    private void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            SpawnAsteroids();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    private void SpawnAsteroids()
    {
        float stepX = spawnRadius * 2.0f / gridWidth;
        float stepY = spawnRadius * 2.0f / gridHeight;

        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                Vector3 randomPosition = transform.position + new Vector3(x * stepX - spawnRadius, 0, y * stepY - spawnRadius);

                // Instantiate the asteroid at the calculated position
                Instantiate(asteroidPrefab, randomPosition, Quaternion.identity);
            }
        }
    }
}