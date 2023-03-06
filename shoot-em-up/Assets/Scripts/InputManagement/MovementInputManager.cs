using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(MovementComponent))]
public class MovementInputManager : MonoBehaviour
{
    [Header("Components")]
    private MovementComponent _mc;

    private void Awake()
    {
        _mc = GetComponent<MovementComponent>();
    }
    public void OnMoveInput(InputAction.CallbackContext context)
    {
        _mc.Move(context.ReadValue<Vector2>());
    }
}
