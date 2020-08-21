using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    private RoomManager roomManager;

    private void Awake()
    {
        roomManager = FindObjectOfType<RoomManager>();
    }

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);

        if (Stats.Health <= 0)
        {
            Destroy(gameObject);
        }

        //TODO: Knockback?
    }

    private void OnDestroy()
    {
        roomManager.RemoveEnemy(gameObject);
    }
}