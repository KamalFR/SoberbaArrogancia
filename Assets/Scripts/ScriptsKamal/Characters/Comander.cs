using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comander : PlayerBase
{
    private GameObject bullet; 
    public override void EnterCharacter(ChangeCharacterControl player)
    {
        player.GetComponent<PolygonCollider2D>().enabled = false;
        player.GetComponent<BoxCollider2D>().isTrigger = false;
        player.GetPlayerMovement().SetSpeed(0);
        bullet = player.GetBulletPrefab();
        player.SetIsIuno(false);
    }
    public override void UpdateCharacter(ChangeCharacterControl player)
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shootedBullet = MonoBehaviour.Instantiate(bullet, player.transform.position + player.GetPlayerMovement().GetLastMove(), Quaternion.identity);
            shootedBullet.GetComponent<BulletScript>().SetBulletTragetory(player.GetPlayerMovement().GetLastMove()); 
        }
    }
}
