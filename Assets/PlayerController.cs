using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A has been pressed");
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A is being held down");
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("A has been released");
        }
    }
    void OnMove()
    {
        Debug.Log("Player is moving");
    }
}
