using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private int speed = 10;
    private Rigidbody2D rb;
    private PlayerInputs input;
    private Vector3 lastMove;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        input = new PlayerInputs();
    }
    private void OnEnable()
    {
        input.Enable();
        input.Player.Walk.performed += OnMove;
        input.Player.Walk.started += OnMove;
        input.Player.Walk.canceled += OnMove;

    }
    private void OnDisable()
    {
        input.Disable();
        input.Player.Walk.performed -= OnMove;
        input.Player.Walk.started -= OnMove;
        input.Player.Walk.canceled -= OnMove;
    }
    public void SetLastMove(Vector3 movementDirection)
    {
        Vector3 zero = new Vector3(0f, 0f, 0f);
        movementDirection.y = 0f;
        if ((movementDirection.x != 0) && (System.Math.Abs(movementDirection.x) < 1))
        {
            movementDirection.x /= 0.71f;
        }
        if (movementDirection != zero)
        {
            lastMove = movementDirection;
        }
    }
    private void OnMove(InputAction.CallbackContext context)
    {
        Vector3 movementDirection = context.ReadValue<Vector2>();
        if((movementDirection.x != 0) && (System.Math.Abs(movementDirection.x) < 1))
        {
            movementDirection.x /= 0.71f;
        }
        if (speed > 0f)
        {
            rb.velocity = new Vector3(movementDirection.x, rb.velocity.y / speed, 0f) * speed; //os comandos não podem alterar a velocidade do pulo
        }
        SetLastMove(context.ReadValue<Vector2>());
    }
    public int GetSpeed()
    {
        return speed;
    }
    public void SetSpeed(int speed)
    {
        this.speed = speed;
    }
    public Vector3 GetLastMove()
    {
        return lastMove;
    }
    public Rigidbody2D GetRigidbody2D()
    {
        return rb;
    }
}
