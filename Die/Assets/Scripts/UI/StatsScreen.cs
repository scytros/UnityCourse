using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsScreen : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private GameObject playerScreen;

    [SerializeField] private Text healthText;
    [SerializeField] private Image healthImage;

    private InputManager controls;

    private bool isOpen;

    private float lastHealth;

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
        if (lastHealth != player.Stats.Health)
        {
            lastHealth = player.Stats.Health;

            float currentHealth = player.Stats.Health;
            float maxHealth = player.Stats.MaxHealth;
            float fillValue = ((maxHealth * currentHealth) / 100) / 100;

            healthText.text = currentHealth + " / " + maxHealth;
            healthImage.fillAmount = fillValue;
        }
    }

    private void ToggleStats()
    {
        isOpen = !isOpen;

        playerScreen.SetActive(isOpen);
    }
}