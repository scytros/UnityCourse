﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private InputManager controls;

    [SerializeField] private GameObject arrowPrefab;

    [SerializeField] private float cooldown = 10;
    [SerializeField] private float cooldownLeft = 0;
    [SerializeField] private bool canAttack = true;

    private void Awake()
    {
        controls = new InputManager();
        controls.Player.Attack.performed += ctx => UseAttack();
    }
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Update()
    {
        if (cooldownLeft > 0)
        {
            cooldownLeft -= (1 * Time.deltaTime);
        }
        else
        {
            cooldownLeft = 0;
            canAttack = true;
        }
    }

    private void UseAttack()
    {
        if (!canAttack) return;

        cooldownLeft = cooldown;
        canAttack = false;
        SpawnProjectile();
    }

    private void SpawnProjectile()
    {
        GameObject projectile = GameObject.Instantiate(arrowPrefab);
        projectile.transform.position = transform.position;
        projectile.transform.rotation = transform.rotation;
    }
}