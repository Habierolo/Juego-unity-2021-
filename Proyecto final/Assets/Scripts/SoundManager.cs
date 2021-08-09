using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;

    public static SoundManager SharedInstance;

    private void Awake()
    {
        if (SharedInstance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            SharedInstance = this;
        }
        DontDestroyOnLoad(gameObject);
    }
    public void PlayMusic(AudioClip clip)
    {
        musicSource.Stop();
        musicSource.clip = clip;
        musicSource.Play();
    }
}
