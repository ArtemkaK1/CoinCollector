using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public int coinCount = 10;
    public float spacing = 8f;
    public Vector2 startPosition = new Vector2(-40, -1);

    void Start()
    {
        SpawnCoins();
    }

    void SpawnCoins()
    {
        for (int i = 0; i < coinCount; i++)
        {
            Vector2 spawnPosition = new Vector2(startPosition.x + i * spacing, startPosition.y);
            Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
