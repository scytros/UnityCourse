using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStats : MonoBehaviour
{
    [SerializeField] private Player player;

    [SerializeField] private Text health;
    [SerializeField] private Text movementSpeed;
    [SerializeField] private Text projectileCount;
    [SerializeField] private Text projectileDamage;
    [SerializeField] private Text projectileSpeed;
    [SerializeField] private Text projectileBounces;

    private void Update()
    {
        RedrawStats();
    }

    public void RedrawStats()
    {
        health.text = "Health: " + player.PlayerStats.Health.ToString();
        movementSpeed.text = "MovementSpeed: " + player.PlayerStats.MovementSpeed.ToString();
        projectileCount.text = "MovementSpeed: " + player.PlayerStats.ExtraUpgrades.ProjectileCount.ToString();
        projectileDamage.text = "MovementSpeed: " + player.PlayerStats.ExtraUpgrades.ProjectileDamage.ToString();
        projectileSpeed.text = "MovementSpeed: " + player.PlayerStats.ExtraUpgrades.ProjectileSpeed.ToString();
        projectileBounces.text = "MovementSpeed: " + player.PlayerStats.ExtraUpgrades.ProjectileBounces.ToString();
    }
}
