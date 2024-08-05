using UnityEngine;

public class CarroSpawner : MonoBehaviour
{
    public GameObject carPrefab; // O prefab do carro azul
    public float spawnInterval = 3f; // Intervalo de tempo entre os spawns
    public float minX, maxX; // Limites na direção X para spawn
    public float minY, maxY; // Limites na direção Y para spawn

    private float nextSpawnTime;

    void Start()
    {
        nextSpawnTime = Time.time + spawnInterval;
    }

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            SpawnCar();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnCar()
    {
        // Gera uma posição aleatória dentro dos limites definidos
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(randomX, randomY, 0);

        // Instancia o prefab do carro na posição aleatória
        Instantiate(carPrefab, spawnPosition, Quaternion.identity);
    }
}