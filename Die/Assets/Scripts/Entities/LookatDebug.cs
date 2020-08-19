using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatDebug : MonoBehaviour
{
    [SerializeField] private Color color;
    [SerializeField] private float distance = 20f;

    private void FixedUpdate()
    {
        Debug.DrawRay(transform.position, transform.up * distance, color);
    }
}