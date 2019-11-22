using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject background;
    public Sprite[] backgroundSprites;

    private SpriteRenderer backgroundSpriteRenderer;

    private void Start()
    {
        backgroundSpriteRenderer = background.GetComponent<SpriteRenderer>();

        SetRandomBackground(backgroundSprites);
    }

    private void SetRandomBackground(params Sprite[] sprites)
    {
        if(sprites != null)
        {
            int randomSpriteIndex = Random.Range(0, sprites.Length);
            backgroundSpriteRenderer.sprite = sprites[randomSpriteIndex];
        }
    }
}
