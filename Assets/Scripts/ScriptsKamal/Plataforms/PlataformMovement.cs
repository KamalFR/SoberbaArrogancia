using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformMovement : MonoBehaviour
{
    [SerializeField] private Transform[] plataformPoints;
    [SerializeField] private float speed;
    private int count;
    private void Awake()
    {
        count = 0;
    }
    private void Update()
    {
        if (count >= plataformPoints.Length)
        {
            count = 0;
        }
        if (Vector3.Distance(transform.position, plataformPoints[count].position) < 0.05f) //só por segurança
        {
            count++;
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, plataformPoints[count].position, speed * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlataformPoints")
        {
            count++;
        }
    }
}
