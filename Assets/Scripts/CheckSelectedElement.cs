using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSelectedElement : MonoBehaviour
{
    public Color rightChoiceColor;
    public Color wrongChoiceColor;

    public Sprite rightSprite;

    private bool isRightChoice = false;
    public bool IsRightChoice
    {
        get { return isRightChoice; }
    }

    public void CheckCorrectness(Sprite sprite)
    {
        if(sprite == rightSprite)
        {
            isRightChoice = true;
        }
        else
        {
            isRightChoice = false;
        }
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
