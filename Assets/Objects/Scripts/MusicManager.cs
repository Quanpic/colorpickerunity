using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager _musicManager;
    private AudioSource audioSource;

    private void Awake()
    {
        if (_musicManager == null)
        {
            _musicManager = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();
    }


    public void PlayMusic()
    {
        if (audioSource.isPlaying) return;
        audioSource.Play();
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }

    public bool isMusicPlayed()
    {
        if (audioSource.isPlaying)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
