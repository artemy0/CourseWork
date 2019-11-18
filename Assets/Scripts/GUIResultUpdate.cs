using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GUIResultUpdate : MonoBehaviour
{
    public Text resultsText;

    private void Start()
    {
        resultsText.text = "правильные ответы: " + ResultsSave.RightAnswersNumber + "/" + ResultsSave.TotalQuestions;
    }
}
