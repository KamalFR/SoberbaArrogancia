using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class ButtonScale : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float size;
    public float duration;

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.DOScale(size, duration);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.DOScale(1f, duration);
    }
}
