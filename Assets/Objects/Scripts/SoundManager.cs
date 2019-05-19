using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static SoundManager _soundManager;
    public static AudioClip brokeSound, loseSound;
    private AudioSource audioSource;

    private void Awake()
    {
        if (_soundManager == null)
        {
            _soundManager = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
        brokeSound = Resources.Load<AudioClip>("broke");
        loseSound = Resources.Load<AudioClip>("lose");
        audioSource = GetComponent<AudioSource>();
    }

//    void Start()
//    {
//        
//        
//        audioSource = GetComponent<AudioSource>();
//    }

//    void Update()
//    {
//        
//    }


    public void PlaySound(string clip)
    {
        switch (clip)
        {
            case "broke":
                audioSource.PlayOneShot(brokeSound);
                break;
            case "lose":
                audioSource.PlayOneShot(loseSound);
                break;
        }
    }
}
