using DG.Tweening;
using UnityEngine;

public class BigBoss : MonoBehaviour
{
    public float speed;
    public float minDistance; //distância mínima do boss pro player

    private Vector3 _direction;

    private void Update()
    {
        Movements();
    }

    public void Movements()
    {
        //checa a direção que o player está e vai até lá
        if (PlayerPosition.instance.transform.position.x > transform.position.x)
        {
            _direction = new Vector3(1, 0);
            if (transform.localScale != Vector3.one) transform.DOScaleX(1, .01f);
        }
        else if (PlayerPosition.instance.transform.position.x < transform.position.x)
        {
            _direction = new Vector3(-1, 0);
            if (transform.localScale != -Vector3.one) transform.DOScaleX(-1, .01f);
        }

        while (Vector3.Distance(transform.position, PlayerPosition.instance.transform.position) > minDistance)
        {
            transform.position += _direction * speed * Time.deltaTime;
            break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //recuo ao tocar o player
        if (collision.transform.tag == "Player")
        {
            transform.DOMoveX(transform.position.x -_direction.x, .9f);

            CheckPointManager.instance.Kill();
        }
    }
}
