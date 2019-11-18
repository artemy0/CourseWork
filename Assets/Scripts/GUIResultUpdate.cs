using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GUIResultUpdate : MonoBehaviour
{
    public Text resultsText;

    private void Start()
    {
        resultsText.text = "right answers: " + ResultsSave.RightAnswersNumber + "/" + ResultsSave.TotalQuestions;
    }
}
