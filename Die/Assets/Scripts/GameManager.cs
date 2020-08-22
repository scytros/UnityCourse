using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private AudioSource oneShotAudioSource;
    [SerializeField] private AudioSource gameMusicAudioSource;

    [SerializeField] private AudioClip roomStart;
    [SerializeField] private AudioClip roomCompleted;
    [SerializeField] private AudioClip projectileHit;

    public enum Sound
    {
        KeySpawn,
        RoomStart,
        RoomCompleted,
        ProjectileHit
    }

    private void Awake()
    {
        Time.timeScale = 1;
    }

    public void PlayAudio(Sound sound)
    {
        switch (sound)
        {
            case Sound.RoomStart:
                oneShotAudioSource.PlayOneShot(roomStart);
                break;
            case Sound.RoomCompleted:
                oneShotAudioSource.PlayOneShot(roomCompleted);
                break;
            case Sound.ProjectileHit:
                oneShotAudioSource.PlayOneShot(projectileHit);
                break;
        }
    }

    public void StopGameMusic()
    {
        gameMusicAudioSource.Stop();
    }
}