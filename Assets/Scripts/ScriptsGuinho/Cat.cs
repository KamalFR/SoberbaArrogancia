using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Translate(new Vector2(0, -1) * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            CheckPointManager.instance.Kill();
            Destroy(gameObject, .1f);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
