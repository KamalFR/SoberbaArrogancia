using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            CheckPointManager.instance.Kill();
            Destroy(gameObject, .1f);
        }
        else if(collision.tag == "Floor")
        {
            Destroy(gameObject);
        }
    }
}
