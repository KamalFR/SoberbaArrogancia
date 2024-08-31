using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luksguin.Singleton;

public class CheckPointManager : Singleton<CheckPointManager>
{
    public Transform[] checkPoints; // lista da posição de todos os checkpoints

    [HideInInspector] public int _lastPosition;

    public void Kill()
    {
        PlayerPosition.instance.transform.position = checkPoints[_lastPosition].position;
    }
}
