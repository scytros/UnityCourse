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

    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }

    private void OnEnable()
    {
        RedrawStats();
        Time.timeScale = 0;
    }

    private void OnDisable()
    {
        Time.timeScale = 1;
    }

    public void RedrawStats()
    {
        movementSpeed.text = "MovementSpeed: " + player.Stats.MovementSpeed.ToString();
        projectileCount.text = "ProjectileCount: " + player.Stats.ProjectileCount.ToString();
        projectileDamage.text = "ProjectileDamage: " + player.Stats.ProjectileDamage.ToString();
        projectileSpeed.text = "ProjectileSpeed: " + player.Stats.ProjectileSpeed.ToString();
        projectileBounces.text = "ProjectileBounces: " + player.Stats.ProjectileBounces.ToString();
    }
}