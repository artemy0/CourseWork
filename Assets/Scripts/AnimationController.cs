using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animation anim;

    public void PlayAnim() //проиграть анимацию объекта
    {
        anim.Play();
    }

    public void PlayChildAnim() //проиграть анимацию дочерних объектов (необъодимо что бы проигрывать анимации неопределённых объектов у тайлмапа)
    {
        Animation[] childAnims = this.GetComponentsInChildren<Animation>();

        for (int i = 1; i < childAnims.Length; i++)
        {
            childAnims[i].Play();
        }
    }
}
