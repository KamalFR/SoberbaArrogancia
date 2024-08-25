using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpositePlataforms : MonoBehaviour
{
    [SerializeField] private BlackOrGray thisPlataformColor;
    private void Awake()
    {
        BlackOrGrayControl.activeCollor = BlackOrGray.Black;
    }
    private void Update()
    {
        if(thisPlataformColor != BlackOrGrayControl.activeCollor)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
