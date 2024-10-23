using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField] private float startSpawnInterval = 3f;
    [SerializeField] private GameObject[] _fruitsPrefabs;

    private int _spawnCount = 0;
    private float _currentSpawnInterval;

    void Start()
    {
        _currentSpawnInterval = startSpawnInterval;
        InvokeRepeating("SpawnFruit", _currentSpawnInterval, _currentSpawnInterval);
    }

    void Update()
    {
        
    }

    private void SpawnFruit() {
        _spawnCount++;
        _spawnCount %= 10000;

        int randIndex = Random.Range(0, _fruitsPrefabs.Length);
        Vector3 randomPosition = new Vector3(Random.Range(-9f, 9f), Random.Range(-4f, 6f), 0);

        Instantiate(_fruitsPrefabs[randIndex], randomPosition, _fruitsPrefabs[randIndex].transform.rotation);

        if (_spawnCount == 5) {
            UpdateSpawnInterval(2f);
        }
        else if (_spawnCount == 15) {
            UpdateSpawnInterval(1f);
        }
        else if (_spawnCount == 30) {
            UpdateSpawnInterval(0.5f);
        }
        else if (_spawnCount == 100) {
            UpdateSpawnInterval(0.35f);
        }
    }
    private void UpdateSpawnInterval(float newInterval) {
        CancelInvoke("SpawnFruit");

        _currentSpawnInterval = newInterval;

        InvokeRepeating("SpawnFruit", _currentSpawnInterval, _currentSpawnInterval);
    }
}
