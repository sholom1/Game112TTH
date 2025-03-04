using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Vector2 playerInput;
    private Rigidbody2D rb;
    public float JumpForce = 10;
    public float MoveSpeed = 5;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<Zombie>(out Zombie zombie))
        {
            GameManager.Instance.UpdateScore(2);
            zombie.Die();
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        playerInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            rb.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(playerInput * MoveSpeed, ForceMode2D.Force);
    }
}
