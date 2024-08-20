using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iuno : PlayerBase
{
<<<<<<< HEAD
    public override void EnterCharacter(ChangeCharacterControl player)
    {
        player.GetComponent<PolygonCollider2D>().enabled = false;
        player.GetComponent<BoxCollider2D>().isTrigger = false;
        player.BackToNormalSpeed();
    }
    public override void UpdateCharacter(ChangeCharacterControl player)
    {
        //só segue a vida andando, ainda não sei como vai ser feito os objetos interativos, então é melhor esperar
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
