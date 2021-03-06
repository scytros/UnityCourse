﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStats : MonoBehaviour
{
    [SerializeField] private Player player;

    [SerializeField] private Text movementSpeed;
    [SerializeField] private Text projectileDamage;
    [SerializeField] private Text projectileSpeed;

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
        projectileDamage.text = "ProjectileDamage: " + player.Stats.ProjectileDamage.ToString();
        projectileSpeed.text = "ProjectileSpeed: " + player.Stats.ProjectileSpeed.ToString();
    }
}