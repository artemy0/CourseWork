using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MusicButtonController : MonoBehaviour 
{
    public Button musicOffButton;
    public Button musicOnButton;

    void Start() //метод который срабатывает когда загружается главное меню что бы определить включена ли музывка и следовательно предпринять необходимые меры
    {
        if (ResultsSave.isSoundOn)
        {
            musicOffButton.gameObject.SetActive(false);
            musicOnButton.gameObject.SetActive(true);
        }
        else
        {
            musicOffButton.gameObject.SetActive(true);
            musicOnButton.gameObject.SetActive(false);
        }
    }
}
