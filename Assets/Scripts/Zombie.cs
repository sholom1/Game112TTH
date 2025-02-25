using UnityEngine;

public class Zombie : MonoBehaviour
{
    public ParticleSystem DeathEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnemyManager.Instance.Enemies.Add(this);   
    }
    private void OnDestroy()
    {
        Destroy(Instantiate(DeathEffect, transform.position, Quaternion.identity), 5);
        EnemyManager.Instance.Enemies.Remove(this);
    }
}
