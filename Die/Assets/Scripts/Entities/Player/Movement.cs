using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class Movement : MonoBehaviour
{
    private InputManager controls;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Player player;
    [SerializeField] private Vector2 moveAxis;

    private void Awake()
    {
        controls = new InputManager();
        controls.Player.Movement.performed += Move;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Update()
    {
        float xSpeed = moveAxis.x * Time.deltaTime * player.Stats.MovementSpeed;
        float ySpeed = moveAxis.y * Time.deltaTime * player.Stats.MovementSpeed;

        transform.position += new Vector3(xSpeed, ySpeed);
    }

    private void Move(CallbackContext ctx)
    {
        moveAxis = ctx.ReadValue<Vector2>();
    }
}