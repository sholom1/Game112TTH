using UnityEngine;

public class Zombie : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnemyManager.Instance.Enemies.Add(this);   
    }
    private void OnDestroy()
    {
        EnemyManager.Instance.Enemies.Remove(this);
    }
}
