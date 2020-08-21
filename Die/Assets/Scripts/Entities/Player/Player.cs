using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    public override void TakeDamage(int amount)
    {
        base.TakeDamage(amount);

        if (Stats.Health <= 0)
        {
            FindObjectOfType<EndUI>().SetEndScreen(false);
        }
    }

    public override void Heal(int amount)
    {
        base.Heal(amount);

        //TODO: Cool effect
    }
}