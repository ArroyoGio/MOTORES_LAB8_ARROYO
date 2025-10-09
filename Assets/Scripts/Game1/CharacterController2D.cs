using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class CharacterController2D : MonoBehaviour
{
    public float velocity = 4f;
    private float _direction;
    private Rigidbody2D _rgb2D;
    private Vector2 vector2;
    public void OnMove(InputAction.CallbackContext context)
    {
        Debug.Log(context);
        vector2 = context.ReadValue<Vector2>();
    }
    private void Awake()
    {
        _rgb2D = GetComponent<Rigidbody2D>();
    }

}
