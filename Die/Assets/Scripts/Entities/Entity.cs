using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class Entity : MonoBehaviour
{
    [SerializeField] private Stats stats;
    public Stats Stats { get { return stats; } set { stats = value; } }

    public virtual void TakeDamage(int amount)
    {
        Debug.Log(this.gameObject.name + " took -" + amount + "- of damage");
        stats.Health -= amount;
        //TODO: Cool effect
    }

    public virtual void Heal(int amount)
    {
        stats.Health += amount;
        //TODO: Cool effect
    }
}