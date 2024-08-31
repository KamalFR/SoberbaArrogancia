using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iuno : PlayerBase
{
    public override void EnterCharacter(ChangeCharacterControl player)
    {
        player.GetComponent<PolygonCollider2D>().enabled = false;
        player.GetComponent<BoxCollider2D>().isTrigger = false;
        player.BackToNormalSpeed();
        player.SetIsIuno(true);
    }
    public override void UpdateCharacter(ChangeCharacterControl player)
    {
        if ((Input.GetKeyDown(KeyCode.Space)) && (player.GetCanInteract()))
        {
            player.GetInteractable().ActivePlataform();
            player.SetCanInteract(false);
        }
    }
}
