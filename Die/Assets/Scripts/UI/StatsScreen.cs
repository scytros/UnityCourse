using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsScreen : MonoBehaviour
{
    [SerializeField] private GameObject playerScreen;

    private InputManager controls;

    private bool isOpen;

    private void Awake()
    {
        controls = new InputManager();
        controls.Player.ToggleStatsScreen.performed += ctx => ToggleStats();
        playerScreen.SetActive(false);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void ToggleStats()
    {
        isOpen = !isOpen;

        playerScreen.SetActive(isOpen);
    }
}