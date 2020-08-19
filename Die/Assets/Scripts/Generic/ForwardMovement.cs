using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        transform.position += transform.up * Time.deltaTime * speed;
    }
}
