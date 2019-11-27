using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSelectedElement : MonoBehaviour
{
    public Color rightChoiceColor;
    public Color wrongChoiceColor;

    public Sprite[] rightSprites;

    private bool isRightChoice = false;
    public bool IsRightChoice
    {
        get { return isRightChoice; }
    }

    public void CheckCorrectness(Sprite sprite)
    {
        isRightChoice = false;

        for (int i = 0; i < rightSprites.Length; i++)
            if (sprite == rightSprites[i])
                isRightChoice = true;
    }

    public void CheckResult()
    {
        if (isRightChoice)
        {
            GetComponent<SpriteRenderer>().color = rightChoiceColor;

            //эффекты и звуки с увеличение мчёта
        }
        else
        {
            GetComponent<SpriteRenderer>().color = wrongChoiceColor;
        }
    }
}
