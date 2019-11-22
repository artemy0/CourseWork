using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance = null;

    public AudioSource efxSource;
    public AudioSource musicSource;
    public float lowPitchRange = .95f;
    public float highPitchRange = 1.05f;

    private float musicVolume;

    private void Awake() //реализация паттерна Singleton
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        //сохраняем громкость для последующих манипуляций с музыкой
        musicVolume = instance.musicSource.volume;
    }

    //private void Start()
    //{
    //    if(instance.musicSource.volume == 0f)
    //    {
    //        musicOffButton.gameObject.SetActive(true);
    //        musicOnButton.gameObject.SetActive(false);
    //    }
    //    else
    //    {
    //        musicOffButton.gameObject.SetActive(false);
    //        musicOnButton.gameObject.SetActive(true);
    //    }
    //}  //надо сделать так что бы при переходе на сцену MainMenu вызывался данный скрипт

    public void PlaySingle(AudioClip clip)
    {
        instance.efxSource.clip = clip;

        float randomPitch = Random.Range(lowPitchRange, highPitchRange);
        instance.efxSource.pitch = randomPitch;

        instance.efxSource.Play();
    }

    public void TurnOnMusic()
    {
        instance.musicSource.volume = instance.musicVolume;
        ResultsSave.isSoundOn = true;
    }

    public void TurnOffMusic()
    {
        instance.musicSource.volume = 0f;
        ResultsSave.isSoundOn = false;
    }
}
