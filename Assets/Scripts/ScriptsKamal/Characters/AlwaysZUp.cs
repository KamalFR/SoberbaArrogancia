using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysZUp : PlayerBase
{
    private int jumpForce;
    private bool didSecondJump;
    public override void EnterCharacter(ChangeCharacterControl player)
    {
        player.GetComponent<PolygonCollider2D>().enabled = false;
        player.GetComponent<BoxCollider2D>().isTrigger = false;
        player.BackToNormalSpeed();
        jumpForce = player.GetJumpForce();
        didSecondJump = true; //� necess�rio ser true para a repiti��o do c�digo
    }

    public override void UpdateCharacter(ChangeCharacterControl player)
    {
        if ((Input.GetKeyDown(KeyCode.Space)) && ((player.GetOnFloor())||(!didSecondJump)))
        {
            Vector3 aux = player.GetComponent<Rigidbody2D>().velocity;
            aux.y = 0f;
            player.GetComponent<Rigidbody2D>().velocity = aux;
            player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            if(!didSecondJump)
            {
                didSecondJump = true;
            }
            if (player.GetOnFloor())
            {
                player.SetOnFloor(false);
                didSecondJump = false;
            }
        }
    }
}
