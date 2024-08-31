using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject winMenu;

    private void Start()
    {
        winMenu.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !winMenu.activeSelf) winMenu.SetActive(true);
    }
}
