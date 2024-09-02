using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 aux;
    private void Start()
    {
        aux = player.position;
        aux.z = -10f;
    }
    private void Update()
    {
        aux = player.position;
        aux.z = -10f;
        transform.position = aux;
    }
}
