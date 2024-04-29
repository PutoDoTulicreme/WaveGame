using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector2 spawnPosition;
    public Vector2 spawnBounds;


    // O intervalo de spawn em segundos
    public float spawnInterval = 5.0f;

    // Para manter o tempo decorrido
    private float timeSinceLastSpawn;

    void Start()
    {
        // Inicializa o tempo desde o último spawn como 0
        timeSinceLastSpawn = 0f;
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if (timeSinceLastSpawn >= spawnInterval)
        {
            // Gera uma posição aleatória dentro dos limites
            Vector2 randomPosition = new Vector2(
                Random.Range(-spawnBounds.x / 2, spawnBounds.x / 2),
                Random.Range(-spawnBounds.y / 2, spawnBounds.y / 2)
            );

            // Dá spawn do objeto na posição aleatória
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);

            timeSinceLastSpawn = 0f; // Reseta o tempo decorrido
        }
    }
}
