using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    public int Health { get; set; }
    public float MovementSpeed { get; set; }
    public Upgrades ExtraUpgrades { get; set; }

    public Stats(int health, float movementspeed, Upgrades upgrades)
    {
        Health = health;
        MovementSpeed = movementspeed;
        ExtraUpgrades = upgrades;
    }

    public class Upgrades
    {
        public int ProjectileCount { get; set; }
        public int ProjectileDamage { get; set; }
        public float ProjectileSpeed { get; set; }
        public int ProjectileBounces { get; set; }

        public Upgrades(int projectileCount, int projectileDamage, float projectileSpeed, int projectileBounces)
        {
            ProjectileCount = projectileCount;
            ProjectileDamage = projectileDamage;
            ProjectileSpeed = projectileSpeed;
            ProjectileBounces = projectileBounces;
        }
    }
}