using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndUI : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Image header;
    [SerializeField] private Text title;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject endScreen;

    [SerializeField] private Color victoryColor = Color.green;
    [SerializeField] private string victoryString = "Victory";
    [SerializeField] private AudioClip victoryAudio;

    [SerializeField] private Color defeatColor = Color.red;
    [SerializeField] private string defeatString = "Defeat";
    [SerializeField] private AudioClip defeatAudio;

    private void Awake()
    {
        endScreen.SetActive(false);
    }

    public void SetEndScreen(bool victory)
    {
        Time.timeScale = 0;

        gameManager.StopGameMusic();

        if (victory)
        {
            header.color = victoryColor;
            title.text = victoryString;
            audioSource.clip = victoryAudio;
        }
        else
        {
            header.color = defeatColor;
            title.text = defeatString;
            audioSource.clip = defeatAudio;
        }

        endScreen.SetActive(true);

        audioSource.Play();
    }
}