using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coinPrefab;

    public void SpawnCoin()
    {
        Vector2 spawnPostion = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        Instantiate(coinPrefab, spawnPostion, Quaternion.identity);
    }
}
