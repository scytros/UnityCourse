using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Stats
{
    [SerializeField] private int maxHealth;
    [SerializeField] private int health;
    [SerializeField] private float movementSpeed;
    [SerializeField] private int projectileCount;
    [SerializeField] private int projectileDamage;
    [SerializeField] private float projectileSpeed;
    [SerializeField] private int projectileBounces;

    public int MaxHealth { get { return maxHealth; } set { maxHealth = value; } }
    public int Health { get { return health; } set { health = value; } }
    public float MovementSpeed { get { return movementSpeed; } set { movementSpeed = value; } }
    public int ProjectileCount { get { return projectileCount; } set { projectileCount = value; } }
    public int ProjectileDamage { get { return projectileDamage; } set { projectileDamage = value; } }
    public float ProjectileSpeed { get { return projectileSpeed; } set { projectileSpeed = value; } }
    public int ProjectileBounces { get { return projectileBounces; } set { projectileBounces = value; } }
}