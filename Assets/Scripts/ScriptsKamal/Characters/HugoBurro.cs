using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HugoBurro : PlayerBase
{
    public override void EnterCharacter(ChangeCharacterControl player)
    {
        player.GetComponent<PolygonCollider2D>().enabled = true;
        player.GetComponent<BoxCollider2D>().isTrigger = true;
        player.GetPlayerMovement().SetSpeed(player.GetHugoBurroSpeed());
    }
    public override void UpdateCharacter(ChangeCharacterControl player)
    {
        //só segue a vida andando
    }
}
