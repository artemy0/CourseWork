using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticTransformationsDefinedOnject : MonoBehaviour
{
    public Color selectionColor;
    public Turn turn;

    private SpriteRenderer spriteRenderer;
    private Transform transform;

    public enum Turn
    {
        Left,
        Bottom,
        Right,
        Top
    }

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        transform = GetComponent<Transform>();
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
            case Turn.Left:
                break;
            case Turn.Bottom:
                transform.rotation = new Quaternion(0, 0, 0.7f, 0.7f);
                break;
            case Turn.Right:
                transform.rotation = new Quaternion(0, 0, 1.0f, 0.0f);
                break;
            case Turn.Top:
                transform.rotation = new Quaternion(0, 0, 0.7f, -0.7f);
                break;
        }
    }
}
