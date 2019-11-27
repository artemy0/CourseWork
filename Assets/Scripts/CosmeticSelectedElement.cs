using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticSelectedElement : MonoBehaviour
{
    public Color selectionColor;
    public Turn turn;

    private SpriteRenderer spriteRenderer;

    public enum Turn
    {
        Horizontal,
        Vertical
    }

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ToDetermine()
    {
        ChangeColor();

        ChangeTurn();
    }

    private void ChangeColor()
    {
        spriteRenderer.color = selectionColor;
    }

    private void ChangeTurn()
    {
        switch (turn)
        {
            case Turn.Horizontal:
                break;
            case Turn.Vertical:
                transform.rotation = new Quaternion(0, 0, 0.7f, 0.7f);
                break;
        }
    }
}
