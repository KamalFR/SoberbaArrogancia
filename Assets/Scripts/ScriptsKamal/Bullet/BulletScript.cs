using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float speed;
    private float count;

    private void Awake()
    {
        count = 0;
    }
    public void SetBulletTragetory(Vector3 lastMove)
    {
        GetComponent<Rigidbody2D>().velocity = lastMove * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            //mata o bixo
            Destroy(gameObject);
        }
        if (collision.tag == "Box")
        {
            //destroi a caixa
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        count += Time.deltaTime;
        if(count >= 5f)
        {
            Destroy(gameObject);
        }
    }
}
