using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private AudioSource oneShotAudioSource;
    [SerializeField] private AudioSource gameMusicAudioSource;
    [SerializeField] private AudioClip keySpawn;
    [SerializeField] private AudioClip roomStart;
    [SerializeField] private AudioClip roomCompleted;


    private void Awake()
    {
        Time.timeScale = 1;
    }

    public void PlayAudio(int clip)
    {
        switch (clip)
        {
            case 0:
                oneShotAudioSource.PlayOneShot(keySpawn);
                break;
            case 1:
                oneShotAudioSource.PlayOneShot(roomStart);
                break;
            case 2:
                oneShotAudioSource.PlayOneShot(roomCompleted);
                break;
        }
    }

    public void StopGameMusic()
    {
        gameMusicAudioSource.Stop();
    }
}