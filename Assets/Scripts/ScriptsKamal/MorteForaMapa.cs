using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorteForaMapa : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            CheckPointManager.instance.Kill();
        }
    }
}
