using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    private enum Effect
    {
        Heal,
        AddMovementSpeed,
        AddProjectileSpeed,
        AddProjectileDamage,
    }

    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Effect effect;

    [SerializeField] private int healAmount = 25;
    [SerializeField] private float speedAmount = 1;
    [SerializeField] private float projectileSpeed = 5;
    [SerializeField] private int projectileDamage = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            switch (effect)
            {
                case Effect.Heal:
                    var playerHealth = collision.GetComponent<Player>().Stats.Health;
                    var playerMaxHealth = collision.GetComponent<Player>().Stats.MaxHealth;

                    if ((playerHealth + healAmount) > playerMaxHealth)
                    {
                        collision.GetComponent<Player>().Stats.Health = playerMaxHealth;
                    }
                    else
                    {
                        collision.GetComponent<Player>().Stats.Health += healAmount;
                    }
                    break;
                case Effect.AddMovementSpeed:
                    collision.GetComponent<Player>().Stats.MovementSpeed += speedAmount;
                    break;
                case Effect.AddProjectileSpeed:
                    collision.GetComponent<Player>().Stats.ProjectileSpeed += projectileSpeed;
                    break;
                case Effect.AddProjectileDamage:
                    collision.GetComponent<Player>().Stats.ProjectileDamage += projectileDamage;
                    break;
            }

            Destroy(gameObject);
        }
    }

    public void SetRandomEffect()
    {
        Array values = Enum.GetValues(typeof(Effect));
        System.Random random = new System.Random();
        Effect randomEffect = (Effect)values.GetValue(random.Next(values.Length));

        effect = randomEffect;

        switch (effect)
        {
            case Effect.Heal:
                spriteRenderer.color = Color.red;
                break;
            case Effect.AddMovementSpeed:
                spriteRenderer.color = Color.blue;
                break;
            case Effect.AddProjectileSpeed:
                spriteRenderer.color = Color.green;
                break;
            case Effect.AddProjectileDamage:
                spriteRenderer.color = Color.black;
                break;
        }
    }
}