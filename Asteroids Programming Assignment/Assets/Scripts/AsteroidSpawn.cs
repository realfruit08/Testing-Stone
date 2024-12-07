using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnInterval = 2f;
    public float spawnRadius = 15f;
    private float timeSinceLastSpawn = 0f;
    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        { SpawnAsteroid();
            timeSinceLastSpawn = 0f;
        }
    }
    void SpawnAsteroid()
    {
        Vector2 spawnPosition = Random.insideUnitCircle.normalized * spawnRadius;
        Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
    }
}