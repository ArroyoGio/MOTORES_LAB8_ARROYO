using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class CharacterController2D : MonoBehaviour
{
    private Rigidbody2D myRBD2;
    [SerializeField] private float velocity = 4f;
    private Vector2 moveInput;
    private void Awake()
    {
        myRBD2 = GetComponent<Rigidbody2D>();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        myRBD2.velocity = moveInput * velocity;
    }
}
