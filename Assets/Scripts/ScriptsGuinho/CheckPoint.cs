using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public int index;
    private SpriteRenderer _mySpriteRenderer;
    private AnimatorHelper animator;

    private void Awake()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<AnimatorHelper>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && CheckPointManager.instance._lastPosition < index)
        {
            CheckPointManager.instance._lastPosition = index;

            animator.SetAnimation("Ativado");
        }
    }
}
