using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
using Unity.VisualScripting;
=======
>>>>>>> 0db458e945e75b3f60bca185aeda83c9a8a22cbb
using UnityEngine;

public class HugoBurro : PlayerBase
{
<<<<<<< HEAD
    public override void EnterCharacter(ChangeCharacterControl player)
    {
        player.GetComponent<PolygonCollider2D>().enabled = true;
        player.GetComponent<BoxCollider2D>().isTrigger = true;
        player.GetPlayerMovement().SetSpeed(player.GetHugoBurroSpeed());
    }
    public override void UpdateCharacter(ChangeCharacterControl player)
    {
        //só segue a vida andando
=======
    public override void EnterCharacter(GameObject bullet, int JumpForce, PlayerMovement playerMovement, int hugoBurroSpeed)
    {
        throw new System.NotImplementedException();
    }
    public override void UpdateCharacter()
    {
        throw new System.NotImplementedException();
>>>>>>> 0db458e945e75b3f60bca185aeda83c9a8a22cbb
    }
}
