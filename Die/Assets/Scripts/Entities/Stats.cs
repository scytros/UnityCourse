using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stats
{
    [SerializeField] private int health;
    [SerializeField] private float movementSpeed;
    [SerializeField] private Stats test;
    private Upgrades extraUpgrades;


    public int Health { get { return health; } set { health = value; } }
    public float MovementSpeed { get { return movementSpeed; } set { movementSpeed = value; } }
    public Upgrades ExtraUpgrades { get { return extraUpgrades; } set { extraUpgrades = value; } }

    public Stats(int health, float movementSpeed, Upgrades upgrades)
    {
        this.health = health;
        this.movementSpeed = movementSpeed;
        this.extraUpgrades = upgrades;
    }

    [Serializable]
    public class Upgrades
    {
        [SerializeField] private int projectileCount { get; set; }
        [SerializeField] private int projectileDamage { get; set; }
        [SerializeField] private float projectileSpeed { get; set; }
        [SerializeField] private int projectileBounces { get; set; }

        public int ProjectileCount { get { return projectileCount; } set { projectileCount = value; } }
        public int ProjectileDamage { get { return projectileDamage; } set { projectileDamage = value; } }
        public float ProjectileSpeed { get { return projectileSpeed; } set { projectileSpeed = value; } }
        public int ProjectileBounces { get { return projectileBounces; } set { projectileBounces = value; } }

        public Upgrades(int projectileCount, int projectileDamage, float projectileSpeed, int projectileBounces)
        {
            this.projectileCount = projectileCount;
            this.projectileDamage = projectileDamage;
            this.projectileSpeed = projectileSpeed;
            this.projectileBounces = projectileBounces;
        }
    }
}