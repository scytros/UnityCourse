using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    [SerializeField] private GameObject potionPrefab;

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
            ItemDrop();
            roomManager.RemoveEnemy(gameObject);
            Destroy(gameObject);
        }
    }

    private void ItemDrop()
    {
        System.Random random = new System.Random();
        float randomValue = random.Next(0, 100);

        if (randomValue > 50)
        {
            GameObject potion = GameObject.Instantiate(potionPrefab, transform.position, Quaternion.identity);
            potion.GetComponent<Potion>().SetRandomEffect();
        }
    }
}