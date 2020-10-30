using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D _rigidBody2D;
    [SerializeField] private float _speed = 0f;
    public Vector2 _move;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        _move.x = movementVector.x;
        _move.y = movementVector.y;
    }

    void OnW()
    {
        Debug.Log("Interacted");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidBody2D.velocity = new Vector2(_move.x * _speed, 0f);
    }
}
