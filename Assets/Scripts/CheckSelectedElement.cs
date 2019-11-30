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

    public void CheckCorrectness(Sprite sprite) //проверка на соответствие правильнЫХ спрайта передаваемому спрайту
    {
        isRightChoice = false;

        for (int i = 0; i < rightSprites.Length; i++)
            if (sprite == rightSprites[i])
                isRightChoice = true;
    }

    public void CheckResult() //изменение цвета в зависимости результата проверки на правильность
    {
        if (isRightChoice)
        {
            GetComponent<SpriteRenderer>().color = rightChoiceColor;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = wrongChoiceColor;
        }
    }
}
