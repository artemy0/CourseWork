using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GUIResultUpdate : MonoBehaviour
{
    public Text resultsText;

    private void Start() //при старте сцены с результатами происходит загрузка результатов в resultsText
    {
        resultsText.text = "правильные ответы: " + ResultsSave.RightAnswersNumber + "/" + ResultsSave.TotalQuestions;
    }
}
