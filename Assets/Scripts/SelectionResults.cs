using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionResults : MonoBehaviour
{
    public GameObject parentOfIndefiniteElements;

    private CheckSelectedElement[] indefiniteElements;

    private void Start()
    {
        indefiniteElements = parentOfIndefiniteElements.GetComponentsInChildren<CheckSelectedElement>();
    }

    public void CheckGameResult()
    {
        foreach (CheckSelectedElement indefiniteElement in indefiniteElements)
        {
            indefiniteElement.CheckResult();
        }
    }
}
