using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileHit : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private ForwardMovement forwardMovement;

    [SerializeField] private LayerMask HittableLayers;
    [SerializeField] private LayerMask DamageableLayers;
    [SerializeField] private int bouncesLeft;

    private GameManager gameManager;
    public Entity Host { get; set; }

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (IsInLayerMask(col.gameObject.layer, HittableLayers))
        {
            HandleCollision(col);
        }
    }

    private void HandleCollision(Collider2D col)
    {
        if (IsInLayerMask(col.gameObject.layer, DamageableLayers))
        {
            gameManager.PlayAudio(GameManager.Sound.ProjectileHit);
            col.GetComponent<Entity>().TakeDamage(Host.Stats.ProjectileDamage);

            Destroy(gameObject);
        }

        if (bouncesLeft <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
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