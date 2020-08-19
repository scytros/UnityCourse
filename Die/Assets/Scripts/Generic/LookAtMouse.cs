using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class LookAtMouse : MonoBehaviour
{
    private InputManager controls;

    private void Awake()
    {
        controls = new InputManager();
        controls.Generic.MousePosition.performed += LookAtMousePosition;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void LookAtMousePosition(CallbackContext ctx)
    {
        Vector3 mousePos = ctx.ReadValue<Vector2>();

        Vector3 direction = mousePos - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}