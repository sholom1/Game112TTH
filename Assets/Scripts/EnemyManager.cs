using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance;
    public float Timer = 5;
    public Zombie EnemyPrefab;
    public List<Transform> EnemySpawnPositions;
    public List<Zombie> Enemies;

    private float remainingTime;



    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        remainingTime -= Time.deltaTime;
        if (remainingTime <= 0)
        {
            Vector2 spawnPosition = EnemySpawnPositions[Random.Range(0, EnemySpawnPositions.Count)].position;
            Instantiate(EnemyPrefab, spawnPosition, Quaternion.identity, gameObject.transform);
            remainingTime = Timer;
        }
    }
}
