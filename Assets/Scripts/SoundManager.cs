using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance = null;

    public AudioSource efxSource;
    public AudioSource musicSource;
    public float lowPitchRange = .95f;
    public float highPitchRange = 1.05f;

    private void Awake() //реализация паттерна Singleton
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void PlaySingle(AudioClip clip)
    {
        instance.efxSource.clip = clip;

        float randomPitch = Random.Range(lowPitchRange, highPitchRange);
        instance.efxSource.pitch = randomPitch;

        instance.efxSource.Play();
    }
}
