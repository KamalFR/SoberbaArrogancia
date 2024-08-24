using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public Transform[] checkPoints; // lista da posição de todos os checkpoints

    private void Start()
    {
        PlayerPosition.instance.transform.position = checkPoints[PlayerPrefs.GetInt("Position", 0)].position; // pega a posição do último checkpoint e manda o player pra lá
    }

    //public void OnDisable()
    public void ResetPosition()
    {
        //reseta a posição para o spawn
        PlayerPrefs.SetInt("Position", 0);
        PlayerPrefs.Save();
    }
}
