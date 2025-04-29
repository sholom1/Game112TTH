using UnityEngine;

public class SwitchStatements : MonoBehaviour
{
    public PlayerState State;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (State)
        {
            case PlayerState.None:
                Debug.Log("Doing nothing");
                break;
            case PlayerState.Alive:
                Debug.Log("Living life to the fullest");
                break;
            case PlayerState.Walking:
                Debug.Log("Touching grass");
                break;
            default:
                Debug.Log("idk what I'm doing");
                break;
        }
    }
}

public enum PlayerState
{
    None,
    Alive,
    Dead,
    Walking,
    Eating
}
