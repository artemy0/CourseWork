using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionResults : MonoBehaviour
{
    public GameObject parentOfIndefiniteElements;
    public SceneLoader sceneLoader;

    private CheckSelectedElement[] indefiniteElements;

    private void Start()
    {
        indefiniteElements = parentOfIndefiniteElements.GetComponentsInChildren<CheckSelectedElement>();
    }

    public void CheckGameResult()
    {
        bool allAnswersAreCorrect = true;

        foreach (CheckSelectedElement indefiniteElement in indefiniteElements)
        {
            indefiniteElement.CheckResult();

            if (!indefiniteElement.IsRightChoice)
                allAnswersAreCorrect = false;
        }

        sceneLoader.NextQuestion(allAnswersAreCorrect);
    }
}
