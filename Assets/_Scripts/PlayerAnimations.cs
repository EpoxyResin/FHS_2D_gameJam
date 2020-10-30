using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private PlayerMovement _playerMove;
    private Animator _animator;

    private Rigidbody2D _rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        _playerMove = GetComponent<PlayerMovement>();
        _animator = GetComponent<Animator>();
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_rigidBody2D.velocity.x != 0)
        {
            _animator.Play("Player_Move");
        }
        else 
        { 
            _animator.Play("Player_Idle");
        }

        if (_playerMove._move.x != 0)
        {
            // Flip the Player
            if (_playerMove._move.x < 0f)
            {
                transform.localScale = new Vector2(-1f, 1f);
            }
            else
            {
                transform.localScale = new Vector2(1f, 1f);
            }
        }
    }
}
