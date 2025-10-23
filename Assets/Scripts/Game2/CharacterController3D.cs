using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController3D : MonoBehaviour
{
    private Rigidbody rb;
    public Vector2 moveInput;
    public float speed = 5f;
    public float jumpForce = 7f;

    Color[] colors = { Color.red, Color.green, Color.blue, Color.yellow };
    int colorIndex = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        rb.velocity = new Vector3(move.x * speed, rb.velocity.y, move.z * speed);
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.performed && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    public void OnPreviousColor(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            colorIndex--;
            if (colorIndex < 0) colorIndex = colors.Length - 1;
            GetComponent<Renderer>().material.color = colors[colorIndex];
        }
    }

    public void OnNextColor(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            colorIndex++;
            if (colorIndex >= colors.Length) colorIndex = 0;
            GetComponent<Renderer>().material.color = colors[colorIndex];
        }
    }
}
