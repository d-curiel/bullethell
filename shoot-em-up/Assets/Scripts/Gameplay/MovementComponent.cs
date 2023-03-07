using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementComponent : MonoBehaviour
{
    [Header("Components")]
    private Rigidbody2D _rb;

    [Header("Configuration")]
    [SerializeField]
    private float _speed = 2f;

    [Header("Events")]
    public UnityEvent<int> OnHorizontalMove;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        _rb.velocity = direction * _speed;
        OnHorizontalMove?.Invoke((int)direction.x);
    }
}
