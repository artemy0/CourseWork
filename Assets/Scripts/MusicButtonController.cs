using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MusicButtonController : MonoBehaviour
{
    public Button musicOffButton;
    public Button musicOnButton;

    void Start()
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
