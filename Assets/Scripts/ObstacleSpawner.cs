using System;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 2f;
    public float obstacleSpeed = 5f;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1f, spawnRate);
    }

    // ReSharper disable Unity.PerformanceAnalysis
    [Obsolete("Obsolete")]
    void SpawnObstacle()
    {
        GameObject newObstacle = Instantiate(obstaclePrefab, new Vector3(10, -3, 0), Quaternion.identity);
        newObstacle.AddComponent<Rigidbody2D>().velocity = new Vector2(-obstacleSpeed, 0);
    }
}