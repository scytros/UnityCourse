using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private Entity host;

    private void Start()
    {
        host = GetComponent<ProjectileHit>().Host;
        rb.velocity = transform.up * host.Stats.ProjectileSpeed;
    }
}