using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : SinglationThisObject<SoundManager>
{
    AudioSource[] audioSource;

    private void Awake()
    {
        SingletonThisGameObject(this);

        audioSource = GetComponentsInChildren<AudioSource>();
    }

    public void PlaySound(int index)
    {
        if (!audioSource[index].isPlaying)
        {
            audioSource[index].Play();
        }
    }

    public void StopSound(int index)
    {
        if (audioSource[index].isPlaying)
        {
            audioSource[index].Stop();
        }
    }
}
