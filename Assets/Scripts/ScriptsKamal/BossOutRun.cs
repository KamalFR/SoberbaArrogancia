using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossOutRun : MonoBehaviour
{
    [SerializeField] private GameObject cocao;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            cocao.SetActive(false);
        }
    }
}
