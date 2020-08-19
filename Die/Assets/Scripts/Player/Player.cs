using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Stats PlayerStats;

    public Player()
    {
        PlayerStats = new Stats(100, 10, new Stats.Upgrades(1, 10, 50, 0));
    }

    public void ChangeHealth(int amount)
    {
        PlayerStats.Health -= amount;
        //update Stats
        //update UI
        //if health <= 0 then game over
    }

    public void ChangeMovementSpeed(int amount)
    {

    }
}