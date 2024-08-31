using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMovementPlataform : SwitchControl
{
    [SerializeField] private PlataformMovement plataformMovement;
    public override void ActivePlataform()
    {
        plataformMovement.enabled = true;
        Destroy(gameObject);
    }
}
