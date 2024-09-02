using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundControl : MonoBehaviour
{
    [SerializeField] private SpriteRenderer atualBackground;
    [SerializeField] private Sprite hugoBurroFundo;
    [SerializeField] private Sprite cocaoBerseker;
    private void Start()
    {
        atualBackground.sprite = hugoBurroFundo;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Muda")
        {
            atualBackground.sprite = cocaoBerseker;
        }
    }
}
