using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHit : MonoBehaviour
{
    public Entity Host { get; set; }
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private ForwardMovement forwardMovement;

    [SerializeField] private LayerMask HittableLayers;
    [SerializeField] private LayerMask DamageableLayers;
    [SerializeField] private int bouncesLeft;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (IsInLayerMask(col.gameObject.layer, HittableLayers))
        {
            HandleCollision(col);
        }
    }

    private void HandleCollision(Collision2D col)
    {
        //TODO: Hit sound
        
        if (IsInLayerMask(col.gameObject.layer, DamageableLayers))
        {
            col.collider.GetComponent<Entity>().TakeDamage(Host.Stats.ProjectileDamage);

            Destroy(gameObject);
        }

        if (bouncesLeft <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            //Vector2 inDirection = rb.velocity;
            //Vector2 inNormal = col.contacts[0].normal;
            //Vector2 newVelocity = Vector2.Reflect(inDirection, inNormal);

            //rb.velocity = new Vector2(0, 0);


            //Vector3 newVelocity = Vector3.Reflect(rb.velocity, col.contacts[0].normal);

            //rb.velocity = -newVelocity;
            bouncesLeft--;
        }
    }

    public void SetBounces(int bounces)
    {
        bouncesLeft = bounces;
    }

    public static bool IsInLayerMask(int layer, LayerMask layermask)
    {
        return layermask == (layermask | (1 << layer));
    }
}