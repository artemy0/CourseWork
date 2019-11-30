using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance = null;

    public AudioSource efxSource; //источник для efx звуков
    public AudioSource musicSource; //источник для музыки
    public float lowPitchRange = .95f; //задание тона аудио
    public float highPitchRange = 1.05f;

    private float musicVolume; //громкость музыки

    private void Awake() //реализация паттерна Singleton
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject); //не удалять объект, что бы затем использовать его на других сценах (единый для всех сцен)

        //сохраняем громкость для последующих манипуляций с музыкой
        musicVolume = instance.musicSource.volume;
    }

    public void PlaySingle(AudioClip clip) //метод воспроизводящий клип единократно со случайным тоном
    {
        instance.efxSource.clip = clip; //instance используется так как SoundManager один для всех сцен

        float randomPitch = Random.Range(lowPitchRange, highPitchRange);
        instance.efxSource.pitch = randomPitch;

        instance.efxSource.Play();
    }

    public void TurnOnMusic() //возврощает громкость музыки и сохраняет данные о том что музыка включена в ResultsSave
    {
        instance.musicSource.volume = instance.musicVolume;
        ResultsSave.isSoundOn = true;
    }

    public void TurnOffMusic() //присваивает громкосте музыки 0 и сохраняет данные о том что музыка выключена в ResultsSave
    {
        instance.musicSource.volume = 0f;
        ResultsSave.isSoundOn = false;
    }
}
