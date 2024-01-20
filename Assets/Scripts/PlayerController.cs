using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    private Rigidbody _rb;

    private Vector3 _movementVector = Vector3.zero;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rb.AddForce(_movementVector);
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movement = movementValue.Get<Vector2>();

        _movementVector = new Vector3(movement.x, 0, movement.y);
    }
}
