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
    }
    public override void UpdateCharacter(ChangeCharacterControl player)
    {
        //s� segue a vida andando, ainda n�o sei como vai ser feito os objetos interativos, ent�o � melhor esperar
    }
}
