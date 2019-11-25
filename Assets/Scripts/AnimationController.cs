using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animation anim;

    public void PlayAnim()
    {
        anim.Play();
    }

    public void PlayChildAnim()
    {
        Animation[] childAnims = this.GetComponentsInChildren<Animation>();

        for (int i = 1; i < childAnims.Length; i++)
        {
            childAnims[i].Play();
        }
    }
}
