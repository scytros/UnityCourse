using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] private LayerMask HittableLayers;
    [SerializeField] private bool DestroyOnHit;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (IsInLayerMask(collision.gameObject.layer, HittableLayers))
        {
            Debug.Log("Hit layermask item");

            if (DestroyOnHit)
            {
                Destroy(gameObject);
            }
        }
    }

    public static bool IsInLayerMask(int layer, LayerMask layermask)
    {
        return layermask == (layermask | (1 << layer));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (IsInLayerMask(collision.gameObject.layer, HittableLayers))
        {
            Debug.Log("Hit layermask item");

            if (DestroyOnHit)
            {
                Destroy(gameObject);
            }
        }
    }
}