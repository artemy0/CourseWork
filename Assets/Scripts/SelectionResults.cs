using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionResults : MonoBehaviour
{
    public GameObject parentOfIndefiniteElements; //ссылка на родитель, дочерние элементы которого неопределённые элементы которые нужно будет проверить

    public AudioClip rightAnswerClip;
    public AudioClip wrongAnswerClip;

    private CheckSelectedElement[] indefiniteElements;

    private void Start()
    {
        indefiniteElements = parentOfIndefiniteElements.GetComponentsInChildren<CheckSelectedElement>(); //создаёт массив скриптов CheckSelectedElement каждого дочернего элемента parentOfIndefiniteElements
    }

    public void CheckGameResult()
    {
        bool allAnswersAreCorrect = true;

        foreach (CheckSelectedElement indefiniteElement in indefiniteElements)
        {
            indefiniteElement.CheckResult(); //проверяет правильность присвоенного спрайта элементу

            if (!indefiniteElement.IsRightChoice) //если хотя бы один спрайт элемента указан не верно, конечный результат то же является не верным
                allAnswersAreCorrect = false;
        }

        if (allAnswersAreCorrect)
        {
            ResultsSave.IncrementRightAnswersNumber(); //подсчёт правильных ответов

            SoundManager.instance.PlaySingle(rightAnswerClip);
        }
        else
        {
            SoundManager.instance.PlaySingle(wrongAnswerClip);
        }

        ResultsSave.DecrementQuestionsNumber(); //подсчёт всего ответов
    }
}
