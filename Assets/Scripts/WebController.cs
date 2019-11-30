using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebController : MonoBehaviour //класс для работы с сайтами
{
    public void OpenWebSite(string webPageAddress) //метод реализующий переход на сайт по гипер ссылке
    {
        if (webPageAddress != null)
            Application.OpenURL(webPageAddress); //открытие сайта
    }
}
