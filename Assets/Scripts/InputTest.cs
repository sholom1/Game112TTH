using UnityEngine;

public class InputTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("W key is pressed");
        }
    }
    public void OnMove()
    {
       Debug.Log("Move action is triggered");
    }
}
