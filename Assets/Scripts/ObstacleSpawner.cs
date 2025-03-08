using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float  obstacleSpawnRate = 0.2f;

    private float _timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _timer  += Time.deltaTime;
        if (_timer >= obstacleSpawnRate)
        {
            Instantiate(obstaclePrefab, new Vector3(10f, Random.Range(-2f, 2f), 0f ), Quaternion.identity);
            _timer = 0;
        }
    }
}
