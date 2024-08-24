using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    public Transform[] checkPoints; // lista da posi��o de todos os checkpoints

    private void Start()
    {
        PlayerPosition.instance.transform.position = checkPoints[PlayerPrefs.GetInt("Position", 0)].position; // pega a posi��o do �ltimo checkpoint e manda o player pra l�
    }

    //public void OnDisable()
    public void ResetPosition()
    {
        //reseta a posi��o para o spawn
        PlayerPrefs.SetInt("Position", 0);
        PlayerPrefs.Save();
    }
}
