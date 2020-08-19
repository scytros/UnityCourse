using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    //health
    //movementspeed

    //projectilecount
    //projectiledamge
    //projectilespeed
    //projectilebounces

    public virtual void TakeDamage(int amount)
    {
        //Minus health
    }

    public virtual void Heal(int amount)
    {
        //Add health
    }

    public virtual void ChangeMovementSpeed(int amount)
    {
        //Change movementspeed
    }
}