using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsScreen : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private GameObject playerScreen;
    [SerializeField] private Text healthUI;

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
        player = FindObjectOfType<Player>();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Update()
    {
        RedrawHealth();
    }

    public void RedrawHealth()
    {
        healthUI.text = "Health: " + player.Stats.Health.ToString();
    }

    private void ToggleStats()
    {
        isOpen = !isOpen;

        playerScreen.SetActive(isOpen);
    }
}