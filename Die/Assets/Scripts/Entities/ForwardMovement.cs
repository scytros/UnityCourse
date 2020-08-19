using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 direction;

    private void Start()
    {
        direction = transform.up;
    }

    private void FixedUpdate()
    {
        transform.position += direction * Time.deltaTime * speed;
    }

    public void ChangeDirection(Vector3 newDirection)
    {
        direction = newDirection;
    }
}
