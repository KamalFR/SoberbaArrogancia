using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public int index; //cada toten deve receber um index em ordem crescente
    
    private SpriteRenderer _mySpriteRenderer;

    private void Awake()
    {
        _mySpriteRenderer = GetComponent<SpriteRenderer>();

        if (PlayerPrefs.GetInt("Position") >= index && _mySpriteRenderer) _mySpriteRenderer.color = Color.yellow; //ativa visualmente os totens que já passamos
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // atualiza a última posição
        if (collision.tag == "Player" && PlayerPrefs.GetInt("Position") < index)
        {
            PlayerPrefs.SetInt("Position", index);
            PlayerPrefs.Save();

            if(_mySpriteRenderer) _mySpriteRenderer.color = Color.yellow;
        }
    }
}
