using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] private Bounceable bounceable;
    [SerializeField] private ForwardMovement forwardMovement;

    [SerializeField] private LayerMask HittableLayers;
    [SerializeField] private LayerMask DamageableLayers;
    [SerializeField] private bool DestroyOnHit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsInLayerMask(collision.gameObject.layer, HittableLayers))
        {
            HandleCollision();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsInLayerMask(collision.gameObject.layer, HittableLayers))
        {
            HandleCollision();
        }
    }

    private void HandleCollision()
    {
        Debug.Log("Hit layermask item");

        if (bounceable && bounceable.BouncesLeft > 0)
        {
            Debug.Log("Bounced!");
            bounceable.ReduceBounce();
        }
        else if (DestroyOnHit)
        {
            //TODO: Deal damage to entity hit
            Destroy(gameObject);
        }
    }

    public static bool IsInLayerMask(int layer, LayerMask layermask)
    {
        return layermask == (layermask | (1 << layer));
    }
}